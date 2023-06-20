namespace Cinema_app_Diplom
{
    partial class Managers_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Managers_menu));
            this.label_close = new System.Windows.Forms.Label();
            this.label_sessions_create = new System.Windows.Forms.Label();
            this.label_film_add = new System.Windows.Forms.Label();
            this.label_main = new System.Windows.Forms.Label();
            this.label_employee_add = new System.Windows.Forms.Label();
            this.pictureBox_main = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).BeginInit();
            this.SuspendLayout();
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.BackColor = System.Drawing.Color.Transparent;
            this.label_close.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_close.ForeColor = System.Drawing.Color.White;
            this.label_close.Location = new System.Drawing.Point(24, 389);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(93, 33);
            this.label_close.TabIndex = 11;
            this.label_close.Text = "Назад";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // label_sessions_create
            // 
            this.label_sessions_create.AutoSize = true;
            this.label_sessions_create.BackColor = System.Drawing.Color.Transparent;
            this.label_sessions_create.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sessions_create.ForeColor = System.Drawing.Color.White;
            this.label_sessions_create.Location = new System.Drawing.Point(24, 146);
            this.label_sessions_create.Name = "label_sessions_create";
            this.label_sessions_create.Size = new System.Drawing.Size(238, 33);
            this.label_sessions_create.TabIndex = 9;
            this.label_sessions_create.Text = "Создание сеансов";
            this.label_sessions_create.Click += new System.EventHandler(this.label_sessions_create_Click);
            // 
            // label_film_add
            // 
            this.label_film_add.AutoSize = true;
            this.label_film_add.BackColor = System.Drawing.Color.Transparent;
            this.label_film_add.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_film_add.ForeColor = System.Drawing.Color.White;
            this.label_film_add.Location = new System.Drawing.Point(24, 94);
            this.label_film_add.Name = "label_film_add";
            this.label_film_add.Size = new System.Drawing.Size(285, 33);
            this.label_film_add.TabIndex = 8;
            this.label_film_add.Text = "Добавление фильмов";
            this.label_film_add.Click += new System.EventHandler(this.label_film_add_Click);
            // 
            // label_main
            // 
            this.label_main.AutoSize = true;
            this.label_main.BackColor = System.Drawing.Color.Transparent;
            this.label_main.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_main.ForeColor = System.Drawing.Color.White;
            this.label_main.Location = new System.Drawing.Point(24, 15);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(346, 36);
            this.label_main.TabIndex = 7;
            this.label_main.Text = "Меню для менеджеров:";
            // 
            // label_employee_add
            // 
            this.label_employee_add.AutoSize = true;
            this.label_employee_add.BackColor = System.Drawing.Color.Transparent;
            this.label_employee_add.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_employee_add.ForeColor = System.Drawing.Color.White;
            this.label_employee_add.Location = new System.Drawing.Point(24, 201);
            this.label_employee_add.Name = "label_employee_add";
            this.label_employee_add.Size = new System.Drawing.Size(338, 33);
            this.label_employee_add.TabIndex = 12;
            this.label_employee_add.Text = "Добавление сотрудников";
            this.label_employee_add.Click += new System.EventHandler(this.label_employee_add_Click);
            // 
            // pictureBox_main
            // 
            this.pictureBox_main.BackColor = System.Drawing.Color.Black;
            this.pictureBox_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_main.Image = global::Cinema_app_Diplom.Properties.Resources.Screenshot_1;
            this.pictureBox_main.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_main.Name = "pictureBox_main";
            this.pictureBox_main.Size = new System.Drawing.Size(800, 450);
            this.pictureBox_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_main.TabIndex = 6;
            this.pictureBox_main.TabStop = false;
            // 
            // Managers_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_employee_add);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.label_sessions_create);
            this.Controls.Add(this.label_film_add);
            this.Controls.Add(this.label_main);
            this.Controls.Add(this.pictureBox_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Managers_menu";
            this.Text = "Меню для менеджеров";
            this.Load += new System.EventHandler(this.Managers_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label_sessions_create;
        private System.Windows.Forms.Label label_film_add;
        private System.Windows.Forms.Label label_main;
        private System.Windows.Forms.PictureBox pictureBox_main;
        private System.Windows.Forms.Label label_employee_add;
    }
}