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
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_hall = new System.Windows.Forms.ComboBox();
            this.comboBox_film = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.comboBox_session_time = new System.Windows.Forms.ComboBox();
            this.comboBox_session_price = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(113, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Время сеанса:";
            // 
            // comboBox_hall
            // 
            this.comboBox_hall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hall.FormattingEnabled = true;
            this.comboBox_hall.Location = new System.Drawing.Point(219, 82);
            this.comboBox_hall.Name = "comboBox_hall";
            this.comboBox_hall.Size = new System.Drawing.Size(132, 21);
            this.comboBox_hall.TabIndex = 31;
            this.comboBox_hall.SelectedIndexChanged += new System.EventHandler(this.comboBox_hall_SelectedIndexChanged);
            // 
            // comboBox_film
            // 
            this.comboBox_film.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_film.FormattingEnabled = true;
            this.comboBox_film.Location = new System.Drawing.Point(220, 42);
            this.comboBox_film.Name = "comboBox_film";
            this.comboBox_film.Size = new System.Drawing.Size(132, 21);
            this.comboBox_film.TabIndex = 32;
            this.comboBox_film.SelectedIndexChanged += new System.EventHandler(this.comboBox_film_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(161, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Фильм:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(178, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Зал:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker1.TabIndex = 36;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(122, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Дата сеанса:";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(219, 253);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(80, 44);
            this.button_add.TabIndex = 38;
            this.button_add.Text = "Добавить сеанс";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(320, 276);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(80, 21);
            this.button_close.TabIndex = 39;
            this.button_close.Text = "Отмена";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // comboBox_session_time
            // 
            this.comboBox_session_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_session_time.FormattingEnabled = true;
            this.comboBox_session_time.Location = new System.Drawing.Point(219, 164);
            this.comboBox_session_time.Name = "comboBox_session_time";
            this.comboBox_session_time.Size = new System.Drawing.Size(132, 21);
            this.comboBox_session_time.TabIndex = 40;
            // 
            // comboBox_session_price
            // 
            this.comboBox_session_price.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_session_price.FormattingEnabled = true;
            this.comboBox_session_price.Items.AddRange(new object[] {
            "150",
            "240",
            "320",
            "420",
            "500"});
            this.comboBox_session_price.Location = new System.Drawing.Point(219, 204);
            this.comboBox_session_price.Name = "comboBox_session_price";
            this.comboBox_session_price.Size = new System.Drawing.Size(132, 21);
            this.comboBox_session_price.TabIndex = 41;
            this.comboBox_session_price.SelectedIndexChanged += new System.EventHandler(this.comboBox_session_price_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(63, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Цена сеанса (рублей):";
            // 
            // Sessions_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_session_price);
            this.Controls.Add(this.comboBox_session_time);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_film);
            this.Controls.Add(this.comboBox_hall);
            this.Controls.Add(this.label4);
            this.Name = "Sessions_add";
            this.Text = "Добавление сеансов";
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
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.ComboBox comboBox_session_time;
        private System.Windows.Forms.ComboBox comboBox_session_price;
        private System.Windows.Forms.Label label5;
    }
}