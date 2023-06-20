namespace Cinema_app_Diplom
{
    partial class Admin_panel
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
            this.label_close = new System.Windows.Forms.Label();
            this.label_user_add = new System.Windows.Forms.Label();
            this.label_main = new System.Windows.Forms.Label();
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
            this.label_close.TabIndex = 16;
            this.label_close.Text = "Назад";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // label_user_add
            // 
            this.label_user_add.AutoSize = true;
            this.label_user_add.BackColor = System.Drawing.Color.Transparent;
            this.label_user_add.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_user_add.ForeColor = System.Drawing.Color.White;
            this.label_user_add.Location = new System.Drawing.Point(24, 98);
            this.label_user_add.Name = "label_user_add";
            this.label_user_add.Size = new System.Drawing.Size(363, 33);
            this.label_user_add.TabIndex = 15;
            this.label_user_add.Text = "Добавление пользователей";
            this.label_user_add.Click += new System.EventHandler(this.label_user_add_Click);
            // 
            // label_main
            // 
            this.label_main.AutoSize = true;
            this.label_main.BackColor = System.Drawing.Color.Transparent;
            this.label_main.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_main.ForeColor = System.Drawing.Color.White;
            this.label_main.Location = new System.Drawing.Point(24, 15);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(387, 36);
            this.label_main.TabIndex = 13;
            this.label_main.Text = "Панель администратора:";
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
            this.pictureBox_main.TabIndex = 12;
            this.pictureBox_main.TabStop = false;
            // 
            // Admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.label_user_add);
            this.Controls.Add(this.label_main);
            this.Controls.Add(this.pictureBox_main);
            this.Name = "Admin_panel";
            this.Text = "Панель администратора";
            this.Load += new System.EventHandler(this.Admin_panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label_user_add;
        private System.Windows.Forms.Label label_main;
        private System.Windows.Forms.PictureBox pictureBox_main;
    }
}