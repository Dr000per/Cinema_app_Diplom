using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Cinema_app_Diplom
{
    public partial class Sessions : Form
    {
        DataBase db = new DataBase();
        DataTable films = new DataTable();
        DataTable sessions = new DataTable();
        DateTime date_now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);


        int labelCount = 5;

        int spacing_pic = 40;
        int spacing_lbl = 25;
        int spacing_btn = 15;
        int spacing_pnl = 200;

        int pictureBoxWidth = 160;
        int pictureBoxHeight = 180;

        int labelHeight = 20;

        int buttonHeight = 43;
        int buttonWidth = 96;

        int panelWidth = 900;
        int panelHeight = 170;

        int startY = 70;
        int startX = 37;
        int button_startX = 41;
        int button_startY = 50;
        int panel_startX = 480;
        int panel_startY = 80;

        public Sessions()
        {
            InitializeComponent();
        }

        private void Sessions_Load(object sender, EventArgs e)
        {
            DataTable maxdate = db.ExecuteSql($"select max(date) from sessions");
            dateTimePicker1.MinDate = date_now;
            dateTimePicker1.MaxDate = (DateTime)maxdate.Rows[0].ItemArray[0];
            dateTimePicker1.Value = date_now;
            Generate_sessions();
        }
        

        public void Generate_sessions()
        {
            foreach (Control control in Controls.OfType<Control>().ToList())
            {
                if (control is Label label && label.Text == "Расписание на")
                {
                    continue; 
                }
                else if (control is DateTimePicker)
                {
                    continue;
                }
                else
                {
                    Controls.Remove(control);
                    control.Dispose();
                }
            }
            films = db.ExecuteSql($"select id, film_genre, film_name, duration, poster, age_rating, film_company from film where '{dateTimePicker1.Value}' between Film_release_start AND Film_release_finish");
            int pictureBoxCount = films.Rows.Count;
            for (int i = 0; i < pictureBoxCount; i++)
            {

                sessions = db.ExecuteSql($"select id, id_hall, id_film, date, time, price from sessions where id_film = (select id from film where film_name = '{films.Rows[i].ItemArray[2]}') and date = '{dateTimePicker1.Value}' order by time asc");
                PictureBox pictureBox = new PictureBox();
                Panel panel = new Panel();
                panel.Controls.Clear();
                pictureBox.Size = new Size(pictureBoxWidth, pictureBoxHeight);
                pictureBox.Location = new Point(startX, startY + i * (pictureBoxWidth + spacing_pic));
                pictureBox.BackColor = Color.LightGray;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(films.Rows[i].ItemArray[4].ToString());
                panel.Size = new Size(panelWidth, panelHeight);
                panel.Location = new Point(panel_startX, i * spacing_pnl + panel_startY);
                panel.BorderStyle = BorderStyle.FixedSingle;

                for (int j = 0; j < labelCount; j++)
                {
                    Label label = new Label();
                    switch (j)
                    {
                        case 0:
                            label.Text = films.Rows[i].ItemArray[5].ToString();
                            label.AutoSize = true;
                            label.Location = new Point(pictureBox.Right + spacing_lbl, pictureBox.Location.Y + j * (labelHeight + 20));
                            label.Font = new Font((string)"Microsoft Sans Serif", (float)10.5);

                            this.Controls.Add(label);
                            break;

                        case 1:
                            label.Text = films.Rows[i].ItemArray[1].ToString();
                            label.AutoSize = true;
                            label.Location = new Point(pictureBox.Right + spacing_lbl * 3, pictureBox.Location.Y);
                            label.Font = new Font((string)"Microsoft Sans Serif", (float)10.5);

                            this.Controls.Add(label);
                            break;

                        case 2:
                            label.Text = films.Rows[i].ItemArray[2].ToString();
                            label.AutoSize = true;
                            label.Location = new Point(pictureBox.Right + spacing_lbl, pictureBox.Location.Y + j * (labelHeight + 20));
                            label.Font = new Font((string)"Microsoft Sans Serif", (float)10.5, FontStyle.Bold);

                            this.Controls.Add(label);
                            break;

                        case 3:
                            label.Text = films.Rows[i].ItemArray[6].ToString();
                            label.AutoSize = true;
                            label.Location = new Point(pictureBox.Right + spacing_lbl, pictureBox.Location.Y + j * (labelHeight + 20));
                            label.Font = new Font((string)"Microsoft Sans Serif", (float)10.5);

                            this.Controls.Add(label);
                            break;

                        case 4:
                            label.Text = films.Rows[i].ItemArray[3].ToString();
                            label.AutoSize = true;
                            label.Location = new Point(pictureBox.Right + spacing_lbl, pictureBox.Location.Y + j * (labelHeight + 20));
                            label.Font = new Font((string)"Microsoft Sans Serif", (float)10.25);

                            this.Controls.Add(label);
                            break;
                    }
                }
                for (int b = 0; b < sessions.Rows.Count; b++)
                {
                    Button button = new Button();
                    Label label = new Label();
                    DataTable hall_name = db.ExecuteSql($"select name from cinema_hall where id = {sessions.Rows[b].ItemArray[1]}");
                    decimal price = (decimal)sessions.Rows[b].ItemArray[5];
                    DateTime dt_now = DateTime.Now.Date;
                    DateTime session_time = dateTimePicker1.Value.Add((TimeSpan)sessions.Rows[b].ItemArray[4]);
                    button.Text = $"{session_time.ToShortTimeString()}\n  {(int)Math.Round(price)}" + " руб.";
                    button.Size = new Size(buttonWidth, buttonHeight);
                    button.Location = new Point(button_startX + (buttonWidth + spacing_btn) * b, button_startY);
                    button.BackColor = Color.Purple;
                    button.FlatStyle = FlatStyle.Popup;
                    button.Font = new Font((string)"Microsoft Sans Serif", (float)10, FontStyle.Bold);

                    label.Text = hall_name.Rows[0].ItemArray[0].ToString();
                    label.AutoSize = false;
                    label.Size = new Size(buttonWidth, buttonHeight);
                    label.Location = new Point((button_startX + (buttonWidth + spacing_btn) * b), button_startY + 45);
                    label.Font = new Font((string)"Microsoft Sans Serif", (float)10);
                    label.TextAlign = ContentAlignment.TopCenter;

                    int id_ses = Convert.ToInt32(sessions.Rows[b].ItemArray[0]);

                    button.Click += delegate (object sender, EventArgs e)
                    {
                        switch (label.Text)
                        {
                            case "Стандарт 1":
                                this.Hide();
                                MiddleHall_1 standart_1 = new MiddleHall_1(label.Text, id_ses);
                                standart_1.Show();
                                break;

                            case "Стандарт 2":
                                this.Hide();
                                MiddleHall_2 standart_2 = new MiddleHall_2(label.Text, id_ses);
                                standart_2.Show();
                                break;

                            case "IMAX":
                                this.Hide();
                                IMAXHall_1 IMAX_1 = new IMAXHall_1(label.Text, id_ses);
                                IMAX_1.Show();
                                break;

                            case "Большой зал":
                                this.Hide();
                                HugeHall_1 hugeHall_1 = new HugeHall_1(label.Text, id_ses);
                                hugeHall_1.Show();
                                break;

                            case "Диванный зал":
                                this.Hide();
                                Premium_hall premium_Hall = new Premium_hall(label.Text, id_ses);
                                premium_Hall.Show();
                                break;
                        }
                    };
                    if(session_time > DateTime.Now)
                    {
                        panel.Controls.Add(button);
                        panel.Controls.Add(label);
                    }
                }
                this.Controls.Add(pictureBox);
                this.Controls.Add(panel);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Generate_sessions();
        }
    }
}
