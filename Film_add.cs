using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace Cinema_app_Diplom
{
    public partial class Film_add : Form
    {
        Form main_frm;
        DataBase db = new DataBase();
        DataTable film = new DataTable();
        DateTime date_now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        CheckingTextBoxes checkText = new CheckingTextBoxes();
        public Film_add(Form main_form)
        {
            InitializeComponent();
            this.main_frm = main_form;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Film_add_Load(object sender, EventArgs e)
        {
            int[] hours = new int[24];
            int[] minutes = new int[60];
            DataTable genre_name = db.ExecuteSql("select name from genre");
            DataTable country_name = db.ExecuteSql("select name from country");
            foreach (DataRow row in genre_name.Rows)
            { 
                comboBox_genre.Items.Add(row.ItemArray[0]);
            }
            foreach (DataRow row in country_name.Rows)
            {
                comboBox_country.Items.Add(row.ItemArray[0]);
            }
            
            for (int i = 0; i < 24; i++)
            {
                hours[i] = i;
                comboBox_hours.Items.Add(hours[i]);
            }

            for (int i = 0; i < 60; i++)
            {
                minutes[i] = i;
                comboBox_minutes.Items.Add(minutes[i]);
            }
            foreach (var item in this.Controls)
            {
                if (item is System.Windows.Forms.ComboBox)
                {
                    ((System.Windows.Forms.ComboBox)item).SelectedItem = ((System.Windows.Forms.ComboBox)item).Items[0];
                }
            }
            
            dateTimePicker_finish.MinDate = date_now.AddDays(1);
            dateTimePicker_finish.MaxDate = date_now.AddDays(28);
            dateTimePicker_start.MinDate = date_now;
            dateTimePicker_start.MaxDate = date_now.AddDays(14);

            dateTimePicker_start.KeyDown += DateTimePicker_KeyDown;
            dateTimePicker_finish.KeyDown += DateTimePicker_KeyDown;
        }
        private void DateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.Handled = true;
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            
        }

        private void button_country_add_Click(object sender, EventArgs e)
        {
            
        }

        private void button_genre_add_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox_poster_path_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_poster_path.Text = openFileDialog1.FileName;
            }
        }

        private void dateTimePicker_start_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_finish.MinDate = dateTimePicker_start.Value.AddDays(1);
            dateTimePicker_finish.MaxDate = dateTimePicker_start.Value.AddDays(14);
        }

        private void dateTimePicker_finish_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker_finish.Value > dateTimePicker_start.Value.AddDays(14))
            {
                dateTimePicker_finish.Value = dateTimePicker_start.Value.AddDays(14);
                dateTimePicker_finish.MinDate = dateTimePicker_start.Value.AddDays(1);
                dateTimePicker_finish.MaxDate = dateTimePicker_start.Value.AddDays(14);
            }
        }

        static bool IsNullorWhitespace(params string[] values)
        {
            foreach(string item in values)
            {
                if(string.IsNullOrWhiteSpace((string)item)) return false;
            }
            return true;
        }

        private void label_add_film_Click(object sender, EventArgs e)
        {
            if (IsNullorWhitespace(textBox_company.Text, textBox_film_name.Text, textBox_poster_path.Text, textBox_rating.Text, richTextBox_country.Text, richTextBox_description.Text, richTextBox_genre.Text))
            {
                string duration = comboBox_hours.Text + "." + comboBox_minutes.Text;
                duration = Regex.Replace(duration, @"\u200e", string.Empty);
                DateTime durat = DateTime.ParseExact(duration, "h.m", System.Globalization.CultureInfo.InvariantCulture);
                string message = $"Вы уверены, что хотите добавить данные об этом фильме?\nНазвание: {textBox_film_name.Text}\nЖанр: {richTextBox_genre.Text.Remove(richTextBox_genre.Text.Length - 2).Trim()}\nСтрана: {richTextBox_country.Text.Remove(richTextBox_country.Text.Length - 2).Trim()}\nДлительность: {durat.TimeOfDay}\nОписание: {richTextBox_description.Text}\nРейтинг: {textBox_rating.Text}\nВозрастной рейтинг: {comboBox_age_rating.SelectedItem}\nКинокомпания: {textBox_company.Text.Trim()}\nПуть к постеру фильма: {textBox_poster_path.Text.Trim()}\nДата начала проката: {dateTimePicker_start.Value.ToShortDateString()}\nДата конца проката: {dateTimePicker_finish.Value.ToShortDateString()}";
                DialogResult result = MessageBox.Show(message, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        film = db.ExecuteSql($"select * from film where film_name = '{textBox_film_name.Text.Trim()}' and film_company = '{textBox_company.Text.Trim()}'");
                        if (film.Rows.Count == 0)
                        {
                            try
                            {
                                db.ExecuteNonQuery($"insert into Film (Film_Genre, Film_Country, Film_name, Duration, Poster, Description, Rating, Age_rating, Film_company, Film_release_start, Film_release_finish) values ('{richTextBox_genre.Text.Remove(richTextBox_genre.Text.Length - 2).Trim()}', '{richTextBox_country.Text.Remove(richTextBox_country.Text.Length - 2).Trim()}', '{textBox_film_name.Text.Trim()}', '{durat}', '{textBox_poster_path.Text.Trim()}', '{richTextBox_description.Text.Trim()}', '{textBox_rating.Text.Trim()}', '{comboBox_age_rating.SelectedItem}', '{textBox_company.Text.Trim()}', '{dateTimePicker_start.Value}', '{dateTimePicker_finish.Value}')");
                                MessageBox.Show("Вы успешно добавили фильм: " + textBox_film_name.Text.Trim(), "Уведомление");
                                foreach (var item in this.Controls)
                                {
                                    if (item is System.Windows.Forms.TextBox)
                                    {
                                        ((System.Windows.Forms.TextBox)item).Text = null;
                                    }
                                    else if (item is RichTextBox)
                                    {
                                        ((RichTextBox)item).Text = null;
                                    }
                                    else if (item is System.Windows.Forms.ComboBox)
                                    {
                                        ((System.Windows.Forms.ComboBox)item).SelectedItem = null;
                                    }
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Что-то пошло не так, проверьте все ли поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Введённые Вами данные уже существуют в базе, фильм " + $"{textBox_film_name.Text.Trim()}" + " от компании " + $"{textBox_company.Text.Trim()}" + " уже в прокате", "Попытка добавить существующий фильм!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Что-то пошло не так, проверьте все ли поля заполнены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Убедитесь, что все поля заполнены!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label_back_Click(object sender, EventArgs e)
        {
            main_frm.Show();
            this.Close();
        }

        private void label_add_genre_Click(object sender, EventArgs e)
        {
            richTextBox_genre.Text += comboBox_genre.SelectedItem.ToString() + ", ";
        }

        private void label_add_country_Click(object sender, EventArgs e)
        {
            richTextBox_country.Text += comboBox_country.SelectedItem.ToString() + ", ";
        }

        private void textBox_rating_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!checkText.LengthCheck(textBox_rating.Text, 4))
            {
                if (!textBox_rating.Text.Contains(","))
                {
                    if (checkText.NumCheck(ch) || ch == ',')
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
    }
}
