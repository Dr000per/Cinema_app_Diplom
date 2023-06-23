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
    public partial class Managers_menu : Form
    {
        Form main_frm;
        public Managers_menu(Form form)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            main_frm = form;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Managers_menu_Load(object sender, EventArgs e)
        {
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            main_frm.Show();
            this.Close();
        }

        private void label_film_add_Click(object sender, EventArgs e)
        {
            Film_add film_Add = new Film_add(this);
            film_Add.Show();
            this.Hide();
        }

        private void label_sessions_create_Click(object sender, EventArgs e)
        {
            Sessions_add sessions_Add = new Sessions_add(this);
            sessions_Add.Show();
            this.Hide();
        }

        private void label_employee_add_Click(object sender, EventArgs e)
        {
            Employee_add employee_Add = new Employee_add(this);
            employee_Add.Show();
            this.Hide();
        }

        private void Managers_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
