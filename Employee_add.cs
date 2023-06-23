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
    public partial class Employee_add : Form
    {
        DataBase db = new DataBase();
        DataTable post = new DataTable();

        CheckingTextBoxes checkText = new CheckingTextBoxes();

        Form managers_menu;
        public Employee_add(Form form)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition= FormStartPosition.CenterScreen;
            managers_menu = form;
        }

        private void Employee_add_Load(object sender, EventArgs e)
        {
            textBox_firstname.KeyPress += textBox_surname_KeyPress;
            textBox_middlename.KeyPress += textBox_surname_KeyPress;

            post = db.ExecuteSql($"select name from post where name != 'Администратор';");
            for(int i = 0; i < post.Rows.Count; i++)
            {
                comboBox_post.Items.Add(post.Rows[i].ItemArray[0]);
            }
        }

        private void label_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsNullorWhitespace((string)comboBox_post.SelectedItem, textBox_email.Text, textBox_firstname.Text, textBox_surname.Text, textBox_phone.Text) && !IsNullorWhitespace(textBox_middlename.Text))
                {
                    string message = $"Вы уверены, что хотите добавить данные об этом сотруднике?\nДолжность: {comboBox_post.SelectedItem}\nФамилия: {textBox_surname.Text.Trim()}\nИмя: {textBox_firstname.Text.Trim()}\nОтчество: {textBox_middlename.Text.Trim()}\nEmail: {textBox_email.Text.Trim()}\nТелефон: {textBox_phone.Text.Trim()}";
                    DialogResult result = MessageBox.Show(message, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        db.ExecuteNonQuery($"insert into employee values ((select id from post where name = '{comboBox_post.SelectedItem}'), '{textBox_surname.Text.Trim()}', '{textBox_firstname.Text.Trim()}', 'Отсутствует', '{textBox_email.Text.Trim()}', '{textBox_phone.Text.Trim()}');");
                        MessageBox.Show("Сотрудник успешно добавлен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearBoxes();
                    }
                }
                else if (IsNullorWhitespace(comboBox_post.Text, textBox_email.Text, textBox_firstname.Text, textBox_surname.Text, textBox_phone.Text, textBox_surname.Text))
                {
                    string message = $"Вы уверены, что хотите добавить данные об этом сотруднике?\nДолжность: {comboBox_post.SelectedItem}\nФамилия: {textBox_surname.Text.Trim()}\nИмя: {textBox_firstname.Text.Trim()}\nОтчество: {textBox_middlename.Text.Trim()}\nEmail: {textBox_email.Text.Trim()}\nТелефон: {textBox_phone.Text.Trim()}";
                    DialogResult result = MessageBox.Show(message, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        db.ExecuteNonQuery($"insert into employee values ((select id from post where name = '{comboBox_post.SelectedItem}'), '{textBox_surname.Text.Trim()}', '{textBox_firstname.Text.Trim()}', '{textBox_middlename.Text.Trim()}', '{textBox_email.Text.Trim()}', '{textBox_phone.Text.Trim()}');");
                        MessageBox.Show("Сотрудник успешно добавлен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearBoxes();
                    }
                }
                else
                {
                    MessageBox.Show("Убедитесь, что все нужные поля заполнены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошлок не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            textBox_email.Text = null;
            textBox_firstname.Text = null;
            textBox_surname.Text = null;
            textBox_phone.Text = null;
            textBox_middlename.Text = null;
        }

        private void label_back_Click(object sender, EventArgs e)
        {
            managers_menu.Show();
            this.Close();
        }

        private void textBox_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!textBox_email.Text.Contains("@"))
            {
                if (checkText.EmailCheck(ch) && ch != '@')
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (checkText.EmailCheck(ch))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void textBox_surname_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!checkText.LengthCheck(textBox_phone.Text, 12))
            {
                if (!textBox_phone.Text.Contains("+"))
                {
                    if (checkText.NumCheck(ch) || ch == '+')
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (checkText.NumCheck(ch))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
            else
            {
                if (ch == '\b')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_add_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
