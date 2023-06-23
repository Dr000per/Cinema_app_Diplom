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
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            main_form = form;
        }

        private void Admin_panel_Load(object sender, EventArgs e)
        {
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

        private void Admin_panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}