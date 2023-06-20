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
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            pictureBox_main.BringToFront();
            pictureBox_main.BackColor = Color.Transparent;

            label_main.Parent = pictureBox_main;
            label_menu_for_operators.Parent = pictureBox_main;
            label_menu_for_managers.Parent = pictureBox_main;
            label_menu_for_adm.Parent = pictureBox_main;
            label_close.Parent = pictureBox_main;
        }

        private void label_menu_for_operators_Click(object sender, EventArgs e)
        {
            Sessions sessions= new Sessions(this);
            sessions.Show();
            this.Hide();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_menu_for_managers_Click(object sender, EventArgs e)
        {
            Managers_menu managers_Menu = new Managers_menu(this);
            managers_Menu.Show();
            this.Hide();
        }

        private void label_menu_for_adm_Click(object sender, EventArgs e)
        {
            Admin_panel admin_Panel = new Admin_panel(this);
            admin_Panel.Show();
            this.Hide();
        }
    }
}