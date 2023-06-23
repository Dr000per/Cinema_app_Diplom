namespace Cinema_app_Diplom
{
    partial class Sessions_add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sessions_add));
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_hall = new System.Windows.Forms.ComboBox();
            this.comboBox_film = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_session_time = new System.Windows.Forms.ComboBox();
            this.comboBox_session_price = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_add = new System.Windows.Forms.Label();
            this.label_back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(63, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Время сеанса:";
            // 
            // comboBox_hall
            // 
            this.comboBox_hall.BackColor = System.Drawing.SystemColors.GrayText;
            this.comboBox_hall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_hall.ForeColor = System.Drawing.Color.White;
            this.comboBox_hall.FormattingEnabled = true;
            this.comboBox_hall.Location = new System.Drawing.Point(174, 85);
            this.comboBox_hall.Name = "comboBox_hall";
            this.comboBox_hall.Size = new System.Drawing.Size(132, 21);
            this.comboBox_hall.TabIndex = 31;
            this.comboBox_hall.SelectedIndexChanged += new System.EventHandler(this.comboBox_hall_SelectedIndexChanged);
            // 
            // comboBox_film
            // 
            this.comboBox_film.BackColor = System.Drawing.SystemColors.GrayText;
            this.comboBox_film.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_film.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_film.ForeColor = System.Drawing.Color.White;
            this.comboBox_film.FormattingEnabled = true;
            this.comboBox_film.Location = new System.Drawing.Point(175, 45);
            this.comboBox_film.Name = "comboBox_film";
            this.comboBox_film.Size = new System.Drawing.Size(132, 21);
            this.comboBox_film.TabIndex = 32;
            this.comboBox_film.SelectedIndexChanged += new System.EventHandler(this.comboBox_film_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(111, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Фильм:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(128, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Зал:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker1.TabIndex = 36;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(76, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "Дата сеанса:";
            // 
            // comboBox_session_time
            // 
            this.comboBox_session_time.BackColor = System.Drawing.SystemColors.GrayText;
            this.comboBox_session_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_session_time.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_session_time.ForeColor = System.Drawing.Color.White;
            this.comboBox_session_time.FormattingEnabled = true;
            this.comboBox_session_time.Location = new System.Drawing.Point(174, 167);
            this.comboBox_session_time.Name = "comboBox_session_time";
            this.comboBox_session_time.Size = new System.Drawing.Size(132, 21);
            this.comboBox_session_time.TabIndex = 40;
            // 
            // comboBox_session_price
            // 
            this.comboBox_session_price.BackColor = System.Drawing.SystemColors.GrayText;
            this.comboBox_session_price.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_session_price.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_session_price.ForeColor = System.Drawing.Color.White;
            this.comboBox_session_price.FormattingEnabled = true;
            this.comboBox_session_price.Items.AddRange(new object[] {
            "150",
            "240",
            "320",
            "420",
            "500"});
            this.comboBox_session_price.Location = new System.Drawing.Point(174, 207);
            this.comboBox_session_price.Name = "comboBox_session_price";
            this.comboBox_session_price.Size = new System.Drawing.Size(132, 21);
            this.comboBox_session_price.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(13, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 19);
            this.label5.TabIndex = 42;
            this.label5.Text = "Цена сеанса (рублей):";
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.BackColor = System.Drawing.Color.Transparent;
            this.label_add.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_add.Location = new System.Drawing.Point(191, 244);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(95, 23);
            this.label_add.TabIndex = 43;
            this.label_add.Text = "Добавить";
            this.label_add.Click += new System.EventHandler(this.label_add_Click);
            // 
            // label_back
            // 
            this.label_back.AutoSize = true;
            this.label_back.BackColor = System.Drawing.Color.Transparent;
            this.label_back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_back.Location = new System.Drawing.Point(204, 288);
            this.label_back.Name = "label_back";
            this.label_back.Size = new System.Drawing.Size(61, 19);
            this.label_back.TabIndex = 44;
            this.label_back.Text = "Отмена";
            this.label_back.Click += new System.EventHandler(this.label_back_Click);
            // 
            // Sessions_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Cinema_app_Diplom.Properties.Resources.Screenshot_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 332);
            this.Controls.Add(this.label_back);
            this.Controls.Add(this.label_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_session_price);
            this.Controls.Add(this.comboBox_session_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_film);
            this.Controls.Add(this.comboBox_hall);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sessions_add";
            this.Text = "Создание сеансов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sessions_add_FormClosed);
            this.Load += new System.EventHandler(this.Sessions_add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_hall;
        private System.Windows.Forms.ComboBox comboBox_film;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_session_time;
        private System.Windows.Forms.ComboBox comboBox_session_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.Label label_back;
    }
}