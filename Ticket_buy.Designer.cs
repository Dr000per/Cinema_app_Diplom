namespace Cinema_app_Diplom
{
    partial class Ticket_buy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_accept = new System.Windows.Forms.Button();
            this.radioButton_nal = new System.Windows.Forms.RadioButton();
            this.radioButton_beznal = new System.Windows.Forms.RadioButton();
            this.button_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(25, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 134);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_accept
            // 
            this.button_accept.Location = new System.Drawing.Point(583, 342);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(185, 52);
            this.button_accept.TabIndex = 1;
            this.button_accept.Text = "Подтвердить";
            this.button_accept.UseVisualStyleBackColor = true;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // radioButton_nal
            // 
            this.radioButton_nal.AutoSize = true;
            this.radioButton_nal.Location = new System.Drawing.Point(583, 273);
            this.radioButton_nal.Name = "radioButton_nal";
            this.radioButton_nal.Size = new System.Drawing.Size(113, 17);
            this.radioButton_nal.TabIndex = 2;
            this.radioButton_nal.TabStop = true;
            this.radioButton_nal.Text = "Наличный расчёт";
            this.radioButton_nal.UseVisualStyleBackColor = true;
            // 
            // radioButton_beznal
            // 
            this.radioButton_beznal.AutoSize = true;
            this.radioButton_beznal.Location = new System.Drawing.Point(583, 306);
            this.radioButton_beznal.Name = "radioButton_beznal";
            this.radioButton_beznal.Size = new System.Drawing.Size(130, 17);
            this.radioButton_beznal.TabIndex = 3;
            this.radioButton_beznal.TabStop = true;
            this.radioButton_beznal.Text = "Безналичный расчёт";
            this.radioButton_beznal.UseVisualStyleBackColor = true;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(637, 409);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(81, 29);
            this.button_close.TabIndex = 4;
            this.button_close.Text = "Назад";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Ticket_buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.radioButton_beznal);
            this.Controls.Add(this.radioButton_nal);
            this.Controls.Add(this.button_accept);
            this.Controls.Add(this.panel1);
            this.Name = "Ticket_buy";
            this.Text = "Оплата билетов";
            this.Load += new System.EventHandler(this.Ticket_buy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.RadioButton radioButton_nal;
        private System.Windows.Forms.RadioButton radioButton_beznal;
        private System.Windows.Forms.Button button_close;
    }
}