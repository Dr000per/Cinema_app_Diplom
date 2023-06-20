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
    public partial class Authorization : Form
    {
        DataBase db = new DataBase();

        DataTable users = new DataTable();

        General_values userRole = new General_values();
        public Authorization()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox_password.PasswordChar = '*';
        }

        private void label_back_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            pictureBox_main.BringToFront();

            label_main.Parent = pictureBox_main;
            label_login.Parent = pictureBox_main;
            label_password.Parent = pictureBox_main;
            label_auth.Parent = pictureBox_main;
            label_back.Parent = pictureBox_main;

            textBox_login.Parent = pictureBox_main;
            textBox_password.Parent = pictureBox_main;
        }

        private void label_auth_Click(object sender, EventArgs e)
        {
            users = db.ExecuteSql($"select id_role from users where login = '{textBox_login.Text}' and password = '{textBox_password.Text}'");
            if (users.Rows.Count > 0)
            {
                userRole.UserRole = (int)users.Rows[0].ItemArray[0];
                Main_form main = new Main_form(userRole.UserRole);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует", "Уведомление");
            }
        }
    }
}
