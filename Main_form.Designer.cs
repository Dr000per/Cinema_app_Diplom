namespace Cinema_app_Diplom
{
    partial class Main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.label_main = new System.Windows.Forms.Label();
            this.label_menu_for_operators = new System.Windows.Forms.Label();
            this.label_menu_for_managers = new System.Windows.Forms.Label();
            this.label_menu_for_adm = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.pictureBox_main = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).BeginInit();
            this.SuspendLayout();
            // 
            // label_main
            // 
            this.label_main.AutoSize = true;
            this.label_main.BackColor = System.Drawing.Color.Transparent;
            this.label_main.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_main.ForeColor = System.Drawing.Color.White;
            this.label_main.Location = new System.Drawing.Point(24, 19);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(222, 36);
            this.label_main.TabIndex = 1;
            this.label_main.Text = "Главное меню:";
            // 
            // label_menu_for_operators
            // 
            this.label_menu_for_operators.AutoSize = true;
            this.label_menu_for_operators.BackColor = System.Drawing.Color.Transparent;
            this.label_menu_for_operators.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_menu_for_operators.ForeColor = System.Drawing.Color.White;
            this.label_menu_for_operators.Location = new System.Drawing.Point(24, 98);
            this.label_menu_for_operators.Name = "label_menu_for_operators";
            this.label_menu_for_operators.Size = new System.Drawing.Size(309, 33);
            this.label_menu_for_operators.TabIndex = 2;
            this.label_menu_for_operators.Text = "Для операторов кассы";
            this.label_menu_for_operators.Click += new System.EventHandler(this.label_menu_for_operators_Click);
            // 
            // label_menu_for_managers
            // 
            this.label_menu_for_managers.AutoSize = true;
            this.label_menu_for_managers.BackColor = System.Drawing.Color.Transparent;
            this.label_menu_for_managers.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_menu_for_managers.ForeColor = System.Drawing.Color.White;
            this.label_menu_for_managers.Location = new System.Drawing.Point(24, 151);
            this.label_menu_for_managers.Name = "label_menu_for_managers";
            this.label_menu_for_managers.Size = new System.Drawing.Size(404, 33);
            this.label_menu_for_managers.TabIndex = 3;
            this.label_menu_for_managers.Text = "Для менеджеров кинотеатра";
            this.label_menu_for_managers.Click += new System.EventHandler(this.label_menu_for_managers_Click);
            // 
            // label_menu_for_adm
            // 
            this.label_menu_for_adm.AutoSize = true;
            this.label_menu_for_adm.BackColor = System.Drawing.Color.Transparent;
            this.label_menu_for_adm.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_menu_for_adm.ForeColor = System.Drawing.Color.White;
            this.label_menu_for_adm.Location = new System.Drawing.Point(24, 290);
            this.label_menu_for_adm.Name = "label_menu_for_adm";
            this.label_menu_for_adm.Size = new System.Drawing.Size(476, 33);
            this.label_menu_for_adm.TabIndex = 4;
            this.label_menu_for_adm.Text = "Для администратора кинотеатра";
            this.label_menu_for_adm.Click += new System.EventHandler(this.label_menu_for_adm_Click);
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.BackColor = System.Drawing.Color.Transparent;
            this.label_close.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_close.ForeColor = System.Drawing.Color.White;
            this.label_close.Location = new System.Drawing.Point(24, 393);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(97, 33);
            this.label_close.TabIndex = 5;
            this.label_close.Text = "Выход";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
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
            this.pictureBox_main.TabIndex = 0;
            this.pictureBox_main.TabStop = false;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.label_menu_for_adm);
            this.Controls.Add(this.label_menu_for_managers);
            this.Controls.Add(this.label_menu_for_operators);
            this.Controls.Add(this.label_main);
            this.Controls.Add(this.pictureBox_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Главное окно программы";
            this.Load += new System.EventHandler(this.Main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_main;
        private System.Windows.Forms.PictureBox pictureBox_main;
        private System.Windows.Forms.Label label_menu_for_operators;
        private System.Windows.Forms.Label label_menu_for_managers;
        private System.Windows.Forms.Label label_menu_for_adm;
        private System.Windows.Forms.Label label_close;
    }
}