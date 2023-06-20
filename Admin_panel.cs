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
    public partial class Admin_panel : Form
    {
        Form main_form;
        public Admin_panel(Form form)
        {
            InitializeComponent();
            this.StartPosition= FormStartPosition.CenterScreen;
            main_form= form;
        }

        private void Admin_panel_Load(object sender, EventArgs e)
        {
            pictureBox_main.BringToFront();
            pictureBox_main.BackColor = Color.Transparent;

            label_main.Parent = pictureBox_main;
            label_user_add.Parent = pictureBox_main;
            label_close.Parent = pictureBox_main;
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            main_form.Show();
            this.Close();
        }

        private void label_user_add_Click(object sender, EventArgs e)
        {
            Users_add users_Add = new Users_add(this);
            users_Add.Show();
            this.Hide();
        }
    }
}