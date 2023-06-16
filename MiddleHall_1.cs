using System;
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
    public partial class MiddleHall_1 : Form
    {
        DataBase db = new DataBase();

        int id_session;
        public MiddleHall_1(string text, int id_sess)
        {
            InitializeComponent();
            label19.Text = text;
            id_session = id_sess;
            label19.Font = new Font(label19.Font, FontStyle.Bold);
            MessageBox.Show(id_session.ToString());
        }


        private void Form1_Load(object sender, EventArgs e)
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
                    place.BackColor = Color.Green;
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
    }
}
