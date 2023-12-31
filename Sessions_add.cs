﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_app_Diplom
{
    public partial class Sessions_add : Form
    {
        Form manager_form;

        DataBase db = new DataBase();
        string[] timeFormats = { "H:mm", "H:mm:ss" };
        public Sessions_add(Form form)
        {
            InitializeComponent();
            manager_form = form;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        string timestring;
        private void Sessions_add_Load(object sender, EventArgs e)
        {
            DataTable hall = db.ExecuteSql("select name, time_table from cinema_hall");
            DataTable film_name = db.ExecuteSql("select film_name from film");
            foreach (DataRow row in hall.Rows)
            {
                comboBox_hall.Items.Add(row.ItemArray[0]);
            }
            foreach (DataRow row1 in film_name.Rows)
            {
                comboBox_film.Items.Add(row1.ItemArray[0]);
            }
            dateTimePicker1.Value = DateTime.Now;
            comboBox_hall.Enabled = false;
        }


        private void comboBox_hall_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_session_time.Items.Clear();
            TimeSessionsAdd();
            DurationCheck();
        }

        private void comboBox_film_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable film_release_dates = db.ExecuteSql($"select film_release_start, film_release_finish from film where film_name = '{comboBox_film.SelectedItem}'");
                dateTimePicker1.MinDate = DateTime.Now.Date;
                if ((DateTime)film_release_dates.Rows[0].ItemArray[1] >= DateTime.Now.Date)
                {
                    dateTimePicker1.MaxDate = (DateTime)film_release_dates.Rows[0].ItemArray[1];
                }
                else
                {
                    dateTimePicker1.MaxDate = DateTime.Now.Date;
                }
                dateTimePicker1.Value = dateTimePicker1.MinDate;
                comboBox_hall.Enabled = true;
                if (comboBox_hall.SelectedItem != null)
                {
                    comboBox_session_time.Items.Clear();
                    TimeSessionsAdd();
                    DurationCheck();
                }
            }
            catch
            {
                MessageBox.Show("Случились технические неполадки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DurationCheck()
        {
            try
            {
                DataTable duration = db.ExecuteSql($"select duration from film where film_name = '{comboBox_film.SelectedItem}'");
                DateTime now = DateTime.Now;
                DateTime film_duration_datetime = now.Add((TimeSpan)duration.Rows[0].ItemArray[0]);
                film_duration_datetime = film_duration_datetime.AddMinutes(10);
                TimeSpan film_duration_timespan = film_duration_datetime - now;
                for (int i = 0; i < comboBox_session_time.Items.Count - 1; i++)
                {
                    if (film_duration_timespan > (TimeSpan)comboBox_session_time.Items[i + 1] - (TimeSpan)comboBox_session_time.Items[i])
                    {
                        comboBox_session_time.Items.RemoveAt(i);
                    }
                    
                    DataTable checkSessions = db.ExecuteSql($"select * from sessions where date = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}' and time = '{comboBox_session_time.Items[i]}'");
                    if (checkSessions.Rows.Count != 0)
                    {
                        comboBox_session_time.Items.RemoveAt(i);
                    }
                }
                comboBox_session_time.SelectedItem = comboBox_session_time.Items[0];
            }
            catch
            {
                MessageBox.Show("Случились технические неполадки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void TimeSessionsAdd()
        {
            try
            {
                DataTable time_table = db.ExecuteSql($"select time_table from cinema_hall where name = '{comboBox_hall.SelectedItem}'");
                foreach (DataRow row in time_table.Rows)
                {
                    timestring = row.ItemArray[0].ToString();
                    string[] timeArray = timestring.Split(' ');
                    List<DateTime> timeList = new List<DateTime>();
                    foreach (string timeValue in timeArray)
                    {
                        DateTime time;
                        if (DateTime.TryParseExact(timeValue, timeFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out time))
                        {
                            timeList.Add(time);
                        }
                    }
                    foreach (DateTime time in timeList)
                    {
                        comboBox_session_time.Items.Add(time.TimeOfDay);
                    }
                }
                DurationCheck();
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так, проверьте введённые данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox_film.SelectedItem != null && comboBox_hall.SelectedItem != null && comboBox_session_time.SelectedItem != null)
            {
                comboBox_session_time.Items.Clear();
                TimeSessionsAdd();
                DurationCheck();
            }
        }

        private void label_back_Click(object sender, EventArgs e)
        {
            manager_form.Show();
            this.Close();
        }

        private void label_add_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBox_film.SelectedItem != null && comboBox_hall.SelectedItem != null && comboBox_session_time.SelectedItem != null && comboBox_session_price.SelectedItem != null)
                {
                    db.ExecuteNonQuery($"insert into sessions values ((select id from cinema_hall where name = '{comboBox_hall.SelectedItem}'), (select id from film where Film_name = '{comboBox_film.SelectedItem}'), '{dateTimePicker1.Value}', '{comboBox_session_time.SelectedItem}', {comboBox_session_price.SelectedItem});");
                    MessageBox.Show("Вы успешно добавили сеанс!", "Оповещение");
                    comboBox_session_price.SelectedIndex = 0;
                    comboBox_session_time.Items.Clear();
                    TimeSessionsAdd();
                    DurationCheck();
                }
                else
                {
                    MessageBox.Show("Заполните все данные", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так, проверьте введённые данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
