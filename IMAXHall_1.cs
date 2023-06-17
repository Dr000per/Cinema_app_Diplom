using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_app_Diplom
{
    public partial class IMAXHall_1 : Form
    {
        DataBase db = new DataBase();

        int id_session;
        string hall_name;
        public IMAXHall_1(string text, int id_sess)
        {
            InitializeComponent();
            label1.Text = text;
            hall_name = text;
            id_session = id_sess;
            label1.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void IMAXHall_1_Load(object sender, EventArgs e)
        {
            DataTable poster = db.ExecuteSql($"select poster from film where id = (select id_film from sessions where id = {id_session})");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(poster.Rows[0].ItemArray[0].ToString());
            DataTable places = db.ExecuteSql($"select id_place, paid, reserved, destroyed from tickets where id_session = {id_session}");

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

        private void button_buy_tickets_Click(object sender, EventArgs e)
        {
            if (Place.list.Count > 0)
            {
                this.Hide();
                Ticket_buy ticket_Buy = new Ticket_buy(id_session, hall_name);
                ticket_Buy.Show();
            }
            else
            {
                MessageBox.Show("Для начала выберите место/места на схеме", "Уведомление");
            }
        }
    }
}
