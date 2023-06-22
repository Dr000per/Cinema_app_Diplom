using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cinema_app_Diplom
{
    public partial class Ticket_buy : Form
    {
        public event EventHandler ticket_buy_form_close;

        DataBase db = new DataBase();

        int id_session;
        string hall_name;
        Form hall_form;

        public Ticket_buy(int id_sess, string hall, Form form)
        {
            InitializeComponent();
            id_session = id_sess;
            hall_name = hall;
            this.hall_form = form;
        }

        int spacing_lbl = 2;
        int labelHeight = 20;

        int startY_panel_tickets = 40;
        int startX_panel_tickets = 23;
        private void Ticket_buy_Load(object sender, EventArgs e)
        {
            DataTable film_data = db.ExecuteSql($"select film_name, age_rating, poster from film where id = (select id_film from sessions where id = {id_session})");
            DataTable date_time = db.ExecuteSql($"select date, time from sessions where id = {id_session}");
            Label label = new Label();
            Panel panel = new Panel();
            panel.Size = new Size(248, 265);
            panel.Location = new Point(25, 170);
            panel.BorderStyle = BorderStyle.FixedSingle;

            this.Controls.Add(panel);
            for(int i = 0; i < Place.list.Count; i++)
            {
                Label label_tickets = new Label
                {
                    Text = $"Ряд: {Place.list[i].Row}, Место: {Place.list[i].Number}",
                    AutoSize = true,
                    Location = new Point(startX_panel_tickets, startY_panel_tickets + i * (labelHeight + spacing_lbl)),
                    Font = new Font((string)"Microsoft Sans Serif", (float)10.5)
                };
                panel.Controls.Add(label_tickets);
            }
            if (Place.list.Count < 5 && Place.list.Count > 1)
            {
                label.Text = $"{Place.list.Count} билета";
            }
            else if (Place.list.Count == 5)
            {
                label.Text = $"{Place.list.Count} билетов";
            }
            else
            {
                label.Text = $"{Place.list.Count} билет";
            }

            label1.Text = film_data.Rows[0].ItemArray[0].ToString();
            label1.Font = new Font((string)"Microsoft Sans Serif", (float)10.5, FontStyle.Bold);
            label1.AutoSize = true;

            label2.Text = film_data.Rows[0].ItemArray[1].ToString();
            label2.Font = new Font((string)"Microsoft Sans Serif", (float)10.5, FontStyle.Bold);
            label2.AutoSize = true;

            DateTime data = (DateTime)date_time.Rows[0].ItemArray[0];

            label3.Text = $"Дата: {data.ToShortDateString()} {date_time.Rows[0].ItemArray[1]}";
            label3.Font = new Font((string)"Microsoft Sans Serif", (float)10.5, FontStyle.Bold);
            label3.AutoSize = true;

            pictureBox1.Image = Image.FromFile($"{film_data.Rows[0].ItemArray[2]}");

            label.AutoSize = true;
            label.Location = new Point(startX_panel_tickets, startY_panel_tickets - 20);
            label.Font = new Font((string)"Microsoft Sans Serif", (float)10.5, FontStyle.Bold);

            panel.Controls.Add(label);
        }

        private void button_accept_Click(object sender, EventArgs e)
        {
            DataTable date_time_tickets = db.ExecuteSql($"select date, time from sessions where id = {id_session}");
            DateTime data = (DateTime)date_time_tickets.Rows[0].ItemArray[0];
            if(radioButton_nal.Checked || radioButton_beznal.Checked)
            {
                DialogResult result = MessageBox.Show("Подтвердить продажу выбранных билетов?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (radioButton_nal.Checked)
                    {
                        foreach (var item in Place.list)
                        {
                            db.ExecuteNonQuery($"insert into tickets values ({id_session}, (select id from places where id_hall = (select id from cinema_hall where name = '{hall_name}') and row = {item.Row} and place = {item.Number}), '{data.ToShortDateString()}', '{date_time_tickets.Rows[0].ItemArray[1]}', 1, '{radioButton_nal.Text}');");
                            db.ExecuteNonQuery($"insert into tickets_operations values ((select id from tickets where id = (select max(id) from tickets)), (select id_employee from users where login = '{General_values.UserName}'), '{DateTime.Now.Date.ToString("dd-MM-yyyy")}', 'Покупка');");
                        }
                        MessageBox.Show("Оплата прошла успешно!", "Уведомление");
                        Close_ticket_buy();
                    }
                    else if (radioButton_beznal.Checked)
                    {
                        foreach (var item in Place.list)
                        {
                            db.ExecuteNonQuery($"insert into tickets values ({id_session}, (select id from places where id_hall = (select id from cinema_hall where name = '{hall_name}') and row = {item.Row} and place = {item.Number}), '{data.ToShortDateString()}', '{date_time_tickets.Rows[0].ItemArray[1]}', 1, '{radioButton_beznal.Text}');");
                            db.ExecuteNonQuery($"insert into tickets_operations values ((select id from tickets where id = (select max(id) from tickets)), (select id_employee from users where login = '{General_values.UserName}'), '{DateTime.Now.Date.ToString("dd-MM-yyyy")}', 'Покупка');");
                        }
                        MessageBox.Show("Оплата прошла успешно!", "Уведомление");
                        Close_ticket_buy();
                    }
                }
            }
            else
            {
                MessageBox.Show("Не выбран способ оплаты", "Уведомление");
            }
        }

        private void Close_ticket_buy()
        {
            Place.list.Clear();
            hall_form.Show();
            ticket_buy_form_close?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close_ticket_buy();
        }
    }
}