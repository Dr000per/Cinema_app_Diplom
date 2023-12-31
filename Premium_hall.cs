﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_app_Diplom
{
    public partial class Premium_hall : Form
    {
        public event EventHandler hall_form_close;

        DataBase db = new DataBase();

        Form sessions;
        int id_session;
        string hall_name;
        public Premium_hall(string text, int id_sess, Form form)
        {
            InitializeComponent();
            label19.Text = text;
            id_session = id_sess;
            hall_name = text;
            this.sessions = form;
            label19.Font = new Font(label19.Font, FontStyle.Bold);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void Premium_hall_Load(object sender, EventArgs e)
        {
            Schema_load();
        }

        private void Schema_load()
        {
            DataTable poster = db.ExecuteSql($"select poster from film where id = (select id_film from sessions where id = {id_session})");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(poster.Rows[0].ItemArray[0].ToString());
            DataTable places = db.ExecuteSql($"select id_place, paid from tickets where id_session = {id_session}");

            foreach (var item in this.Controls)
            {
                if (item.GetType() == typeof(Place))
                {
                    Place place = (Place)item;
                    place.BackColor = Color.Lime;
                    for (int i = 0; i < places.Rows.Count; i++)
                    {
                        DataTable row_place = db.ExecuteSql($"select row, place from Places where id = {places.Rows[i].ItemArray[0]}");
                        for (int b = 0; b < row_place.Rows.Count; b++)
                        {
                            if (place.Row == (int)row_place.Rows[b].ItemArray[0] && place.Number == (int)row_place.Rows[b].ItemArray[1])
                            {
                                place.BackColor = Color.Red;
                                place.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        private void Open_ticket_buy()
        {
            Ticket_buy ticket_Buy = new Ticket_buy(id_session, hall_name, this);
            ticket_Buy.ticket_buy_form_close += tickets_buy_form_close;
            ticket_Buy.Show();
            this.Hide();
        }
        private void tickets_buy_form_close(object sender, EventArgs e)
        {
            Schema_load();
            this.Show();
        }

        private void Close_hall_form()
        {
            sessions.Show();
            hall_form_close?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void label_back_Click(object sender, EventArgs e)
        {
            Close_hall_form();
        }

        private void label_buy_tickets_Click(object sender, EventArgs e)
        {
            if (Place.list.Count > 0)
            {
                Open_ticket_buy();
            }
            else
            {
                MessageBox.Show("Для начала выберите место/места на схеме", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
