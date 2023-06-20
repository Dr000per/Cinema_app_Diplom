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
    public partial class Users_add : Form
    {
        DataBase db = new DataBase();
        DataTable roles = new DataTable();
        DataTable emails = new DataTable();

        CheckingTextBoxes checkText = new CheckingTextBoxes();

        Form adm_panel;
        public Users_add(Form form)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            adm_panel = form;
        }

        private void Users_add_Load(object sender, EventArgs e)
        {
            pictureBox_main.BringToFront();

            label_add.Parent = pictureBox_main;
            label_back.Parent = pictureBox_main;
            label_login.Parent = pictureBox_main;
            label_main.Parent = pictureBox_main;
            label_post.Parent = pictureBox_main;
            label_password.Parent = pictureBox_main;
            label_email.Parent = pictureBox_main;
            
            textBox_login.Parent = pictureBox_main;
            textBox_password.Parent = pictureBox_main;

            comboBox_roles.Parent = pictureBox_main;
            comboBox_email.Parent = pictureBox_main;

            roles = db.ExecuteSql($"select name from roles");

            for (int i = 0; i < roles.Rows.Count; i++)
            {
                comboBox_roles.Items.Add(roles.Rows[i].ItemArray[0]);
            }
            EmailsAdd();
        }

        private void label_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsNullorWhitespace((string)comboBox_roles.SelectedItem, (string)comboBox_email.SelectedItem, textBox_login.Text, textBox_password.Text))
                {
                    string message = $"Вы уверены, что хотите добавить данные об этом пользователе?\nРоль: {comboBox_roles.SelectedItem}\nEmail: {comboBox_email.SelectedItem}\nЛогин: {textBox_login.Text.Trim()}\nПароль: {textBox_password.Text.Trim()}";
                    DialogResult result = MessageBox.Show(message, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        db.ExecuteNonQuery($"insert into users values ((select id from roles where name = '{comboBox_roles.SelectedItem}'), (select id from employee where email = '{comboBox_email.SelectedItem}'),'{textBox_login.Text.Trim()}', '{textBox_password.Text.Trim()}');");
                        MessageBox.Show("Пользователь успешно добавлен", "Уведомление");
                        ClearBoxes();
                        EmailsAdd();
                    }
                }
                else
                {
                    MessageBox.Show("Убедитесь, что все нужные поля заполнены", "Уведомление");
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошлок не так", "Уведомление");
            }
        }

        static bool IsNullorWhitespace(params string[] values)
        {
            foreach (string item in values)
            {
                if (string.IsNullOrWhiteSpace((string)item)) return false;
            }
            return true;
        }

        private void ClearBoxes()
        {
            textBox_login.Text = null;
            textBox_password.Text = null;
            comboBox_email.Items.Clear();
        }

        private void label_back_Click(object sender, EventArgs e)
        {
            adm_panel.Show();
            this.Close();
        }

        private void textBox_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!checkText.EmailCheck(ch))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void EmailsAdd()
        {
            emails = db.ExecuteSql($"select Employee.email from Employee where not exists (select 1 from Users where Users.ID_employee = Employee.id);");
            for (int i = 0; i < emails.Rows.Count; i++)
            {
                comboBox_email.Items.Add(emails.Rows[i].ItemArray[0]);
            }
        }
        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!checkText.CyrillicCheck(ch) || ch == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
