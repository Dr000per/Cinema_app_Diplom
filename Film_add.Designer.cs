﻿namespace Cinema_app_Diplom
{
    partial class Film_add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Film_add));
            this.textBox_film_name = new System.Windows.Forms.TextBox();
            this.textBox_poster_path = new System.Windows.Forms.TextBox();
            this.textBox_rating = new System.Windows.Forms.TextBox();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.comboBox_genre = new System.Windows.Forms.ComboBox();
            this.comboBox_country = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox_poster_path = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_add = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.comboBox_hours = new System.Windows.Forms.ComboBox();
            this.comboBox_minutes = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_age_rating = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_company = new System.Windows.Forms.TextBox();
            this.richTextBox_genre = new System.Windows.Forms.RichTextBox();
            this.button_genre_add = new System.Windows.Forms.Button();
            this.richTextBox_country = new System.Windows.Forms.RichTextBox();
            this.button_country_add = new System.Windows.Forms.Button();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_finish = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_poster_path)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_film_name
            // 
            this.textBox_film_name.Location = new System.Drawing.Point(220, 47);
            this.textBox_film_name.Name = "textBox_film_name";
            this.textBox_film_name.Size = new System.Drawing.Size(194, 20);
            this.textBox_film_name.TabIndex = 0;
            // 
            // textBox_poster_path
            // 
            this.textBox_poster_path.Location = new System.Drawing.Point(219, 103);
            this.textBox_poster_path.Name = "textBox_poster_path";
            this.textBox_poster_path.ReadOnly = true;
            this.textBox_poster_path.Size = new System.Drawing.Size(197, 20);
            this.textBox_poster_path.TabIndex = 4;
            // 
            // textBox_rating
            // 
            this.textBox_rating.Location = new System.Drawing.Point(219, 243);
            this.textBox_rating.Name = "textBox_rating";
            this.textBox_rating.Size = new System.Drawing.Size(197, 20);
            this.textBox_rating.TabIndex = 5;
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Location = new System.Drawing.Point(219, 139);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(267, 95);
            this.richTextBox_description.TabIndex = 6;
            this.richTextBox_description.Text = "";
            // 
            // comboBox_genre
            // 
            this.comboBox_genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_genre.FormattingEnabled = true;
            this.comboBox_genre.Location = new System.Drawing.Point(758, 50);
            this.comboBox_genre.Name = "comboBox_genre";
            this.comboBox_genre.Size = new System.Drawing.Size(132, 21);
            this.comboBox_genre.TabIndex = 8;
            // 
            // comboBox_country
            // 
            this.comboBox_country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_country.FormattingEnabled = true;
            this.comboBox_country.Location = new System.Drawing.Point(758, 219);
            this.comboBox_country.Name = "comboBox_country";
            this.comboBox_country.Size = new System.Drawing.Size(132, 21);
            this.comboBox_country.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(534, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Жанр фильма:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(534, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Страна производитель:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(82, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Название фильма:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(60, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Длительность фильма:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Постер (путь к изображению):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(137, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Описание:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(94, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Рейтинг фильма:";
            // 
            // pictureBox_poster_path
            // 
            this.pictureBox_poster_path.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_poster_path.Image")));
            this.pictureBox_poster_path.Location = new System.Drawing.Point(433, 90);
            this.pictureBox_poster_path.Name = "pictureBox_poster_path";
            this.pictureBox_poster_path.Size = new System.Drawing.Size(37, 33);
            this.pictureBox_poster_path.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_poster_path.TabIndex = 19;
            this.pictureBox_poster_path.TabStop = false;
            this.pictureBox_poster_path.Click += new System.EventHandler(this.pictureBox_poster_path_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(219, 458);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(112, 26);
            this.button_add.TabIndex = 20;
            this.button_add.Text = "Добавить фильм";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(356, 458);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(91, 26);
            this.button_close.TabIndex = 21;
            this.button_close.Text = "Отмена";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // comboBox_hours
            // 
            this.comboBox_hours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hours.FormattingEnabled = true;
            this.comboBox_hours.Location = new System.Drawing.Point(220, 73);
            this.comboBox_hours.Name = "comboBox_hours";
            this.comboBox_hours.Size = new System.Drawing.Size(33, 21);
            this.comboBox_hours.TabIndex = 22;
            // 
            // comboBox_minutes
            // 
            this.comboBox_minutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_minutes.FormattingEnabled = true;
            this.comboBox_minutes.Location = new System.Drawing.Point(274, 73);
            this.comboBox_minutes.Name = "comboBox_minutes";
            this.comboBox_minutes.Size = new System.Drawing.Size(37, 21);
            this.comboBox_minutes.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "ч.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(317, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "мин.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(67, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Возрастной рейтинг:";
            // 
            // comboBox_age_rating
            // 
            this.comboBox_age_rating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_age_rating.FormattingEnabled = true;
            this.comboBox_age_rating.Items.AddRange(new object[] {
            "0+",
            "6+",
            "12+",
            "16+",
            "18+"});
            this.comboBox_age_rating.Location = new System.Drawing.Point(220, 283);
            this.comboBox_age_rating.Name = "comboBox_age_rating";
            this.comboBox_age_rating.Size = new System.Drawing.Size(48, 21);
            this.comboBox_age_rating.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(107, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Кинокомпания:";
            // 
            // textBox_company
            // 
            this.textBox_company.Location = new System.Drawing.Point(219, 324);
            this.textBox_company.Name = "textBox_company";
            this.textBox_company.Size = new System.Drawing.Size(195, 20);
            this.textBox_company.TabIndex = 29;
            // 
            // richTextBox_genre
            // 
            this.richTextBox_genre.Location = new System.Drawing.Point(537, 50);
            this.richTextBox_genre.Name = "richTextBox_genre";
            this.richTextBox_genre.ReadOnly = true;
            this.richTextBox_genre.Size = new System.Drawing.Size(211, 90);
            this.richTextBox_genre.TabIndex = 31;
            this.richTextBox_genre.Text = "";
            // 
            // button_genre_add
            // 
            this.button_genre_add.Location = new System.Drawing.Point(758, 116);
            this.button_genre_add.Name = "button_genre_add";
            this.button_genre_add.Size = new System.Drawing.Size(107, 24);
            this.button_genre_add.TabIndex = 32;
            this.button_genre_add.Text = "Добавить  жанр";
            this.button_genre_add.UseVisualStyleBackColor = true;
            this.button_genre_add.Click += new System.EventHandler(this.button_genre_add_Click);
            // 
            // richTextBox_country
            // 
            this.richTextBox_country.Location = new System.Drawing.Point(537, 222);
            this.richTextBox_country.Name = "richTextBox_country";
            this.richTextBox_country.ReadOnly = true;
            this.richTextBox_country.Size = new System.Drawing.Size(211, 90);
            this.richTextBox_country.TabIndex = 33;
            this.richTextBox_country.Text = "";
            // 
            // button_country_add
            // 
            this.button_country_add.Location = new System.Drawing.Point(758, 286);
            this.button_country_add.Name = "button_country_add";
            this.button_country_add.Size = new System.Drawing.Size(107, 24);
            this.button_country_add.TabIndex = 34;
            this.button_country_add.Text = "Добавить страну";
            this.button_country_add.UseVisualStyleBackColor = true;
            this.button_country_add.Click += new System.EventHandler(this.button_country_add_Click);
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Location = new System.Drawing.Point(222, 377);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker_start.TabIndex = 35;
            this.dateTimePicker_start.ValueChanged += new System.EventHandler(this.dateTimePicker_start_ValueChanged);
            // 
            // dateTimePicker_finish
            // 
            this.dateTimePicker_finish.Location = new System.Drawing.Point(222, 416);
            this.dateTimePicker_finish.Name = "dateTimePicker_finish";
            this.dateTimePicker_finish.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker_finish.TabIndex = 36;
            this.dateTimePicker_finish.ValueChanged += new System.EventHandler(this.dateTimePicker_finish_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(66, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "Дата начала проката:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(75, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 16);
            this.label13.TabIndex = 38;
            this.label13.Text = "Дата конца проката:";
            // 
            // Film_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(999, 540);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePicker_finish);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.button_country_add);
            this.Controls.Add(this.richTextBox_country);
            this.Controls.Add(this.button_genre_add);
            this.Controls.Add(this.richTextBox_genre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_company);
            this.Controls.Add(this.comboBox_age_rating);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_minutes);
            this.Controls.Add(this.comboBox_hours);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.pictureBox_poster_path);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_country);
            this.Controls.Add(this.comboBox_genre);
            this.Controls.Add(this.richTextBox_description);
            this.Controls.Add(this.textBox_rating);
            this.Controls.Add(this.textBox_poster_path);
            this.Controls.Add(this.textBox_film_name);
            this.Name = "Film_add";
            this.Text = "Добавление фильма";
            this.Load += new System.EventHandler(this.Film_add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_poster_path)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_film_name;
        private System.Windows.Forms.TextBox textBox_poster_path;
        private System.Windows.Forms.TextBox textBox_rating;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.ComboBox comboBox_genre;
        private System.Windows.Forms.ComboBox comboBox_country;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox_poster_path;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.ComboBox comboBox_hours;
        private System.Windows.Forms.ComboBox comboBox_minutes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_age_rating;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_company;
        private System.Windows.Forms.RichTextBox richTextBox_genre;
        private System.Windows.Forms.Button button_genre_add;
        private System.Windows.Forms.RichTextBox richTextBox_country;
        private System.Windows.Forms.Button button_country_add;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_finish;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}