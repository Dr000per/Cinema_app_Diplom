namespace Cinema_app_Diplom
{
    partial class Users_add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users_add));
            this.label_back = new System.Windows.Forms.Label();
            this.label_add = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_main = new System.Windows.Forms.Label();
            this.comboBox_roles = new System.Windows.Forms.ComboBox();
            this.label_post = new System.Windows.Forms.Label();
            this.comboBox_email = new System.Windows.Forms.ComboBox();
            this.label_email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_back
            // 
            this.label_back.AutoSize = true;
            this.label_back.BackColor = System.Drawing.Color.Transparent;
            this.label_back.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_back.ForeColor = System.Drawing.Color.White;
            this.label_back.Location = new System.Drawing.Point(211, 356);
            this.label_back.Name = "label_back";
            this.label_back.Size = new System.Drawing.Size(62, 23);
            this.label_back.TabIndex = 22;
            this.label_back.Text = "Назад";
            this.label_back.Click += new System.EventHandler(this.label_back_Click);
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.BackColor = System.Drawing.Color.Transparent;
            this.label_add.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add.ForeColor = System.Drawing.Color.White;
            this.label_add.Location = new System.Drawing.Point(181, 312);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(122, 31);
            this.label_add.TabIndex = 21;
            this.label_add.Text = "Добавить";
            this.label_add.Click += new System.EventHandler(this.label_add_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.Transparent;
            this.label_login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.ForeColor = System.Drawing.Color.White;
            this.label_login.Location = new System.Drawing.Point(75, 188);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(55, 19);
            this.label_login.TabIndex = 20;
            this.label_login.Text = "Логин:";
            // 
            // textBox_login
            // 
            this.textBox_login.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_login.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.ForeColor = System.Drawing.Color.Transparent;
            this.textBox_login.Location = new System.Drawing.Point(78, 210);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(171, 15);
            this.textBox_login.TabIndex = 19;
            this.textBox_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_login_KeyPress);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_password.ForeColor = System.Drawing.Color.White;
            this.label_password.Location = new System.Drawing.Point(75, 233);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(61, 19);
            this.label_password.TabIndex = 18;
            this.label_password.Text = "Пароль:";
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.ForeColor = System.Drawing.Color.Transparent;
            this.textBox_password.Location = new System.Drawing.Point(78, 258);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(171, 15);
            this.textBox_password.TabIndex = 17;
            this.textBox_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_password_KeyPress);
            // 
            // label_main
            // 
            this.label_main.AutoSize = true;
            this.label_main.BackColor = System.Drawing.Color.Transparent;
            this.label_main.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_main.ForeColor = System.Drawing.Color.White;
            this.label_main.Location = new System.Drawing.Point(73, 9);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(337, 33);
            this.label_main.TabIndex = 16;
            this.label_main.Text = "Добавление пользователя:";
            // 
            // comboBox_roles
            // 
            this.comboBox_roles.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox_roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_roles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_roles.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_roles.ForeColor = System.Drawing.Color.Transparent;
            this.comboBox_roles.FormattingEnabled = true;
            this.comboBox_roles.Location = new System.Drawing.Point(79, 108);
            this.comboBox_roles.Name = "comboBox_roles";
            this.comboBox_roles.Size = new System.Drawing.Size(171, 23);
            this.comboBox_roles.TabIndex = 25;
            // 
            // label_post
            // 
            this.label_post.AutoSize = true;
            this.label_post.BackColor = System.Drawing.Color.Transparent;
            this.label_post.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_post.ForeColor = System.Drawing.Color.White;
            this.label_post.Location = new System.Drawing.Point(75, 86);
            this.label_post.Name = "label_post";
            this.label_post.Size = new System.Drawing.Size(110, 19);
            this.label_post.TabIndex = 24;
            this.label_post.Text = "Права доступа:";
            // 
            // comboBox_email
            // 
            this.comboBox_email.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox_email.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_email.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_email.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_email.ForeColor = System.Drawing.Color.Transparent;
            this.comboBox_email.FormattingEnabled = true;
            this.comboBox_email.Location = new System.Drawing.Point(78, 159);
            this.comboBox_email.Name = "comboBox_email";
            this.comboBox_email.Size = new System.Drawing.Size(171, 23);
            this.comboBox_email.TabIndex = 27;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.BackColor = System.Drawing.Color.Transparent;
            this.label_email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_email.ForeColor = System.Drawing.Color.White;
            this.label_email.Location = new System.Drawing.Point(74, 137);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(45, 19);
            this.label_email.TabIndex = 26;
            this.label_email.Text = "Email:";
            // 
            // Users_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cinema_app_Diplom.Properties.Resources.Screenshot_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 412);
            this.Controls.Add(this.comboBox_email);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.comboBox_roles);
            this.Controls.Add(this.label_post);
            this.Controls.Add(this.label_back);
            this.Controls.Add(this.label_add);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_main);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Users_add";
            this.Text = "Добавление пользователя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Users_add_FormClosed);
            this.Load += new System.EventHandler(this.Users_add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_back;
        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_main;
        private System.Windows.Forms.ComboBox comboBox_roles;
        private System.Windows.Forms.Label label_post;
        private System.Windows.Forms.ComboBox comboBox_email;
        private System.Windows.Forms.Label label_email;
    }
}