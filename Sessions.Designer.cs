namespace Cinema_app_Diplom
{
    partial class Sessions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sessions));
            this.label_raspisanie = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_raspisanie
            // 
            this.label_raspisanie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_raspisanie.AutoSize = true;
            this.label_raspisanie.BackColor = System.Drawing.Color.Transparent;
            this.label_raspisanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_raspisanie.ForeColor = System.Drawing.Color.White;
            this.label_raspisanie.Location = new System.Drawing.Point(1105, 11);
            this.label_raspisanie.Name = "label_raspisanie";
            this.label_raspisanie.Size = new System.Drawing.Size(133, 20);
            this.label_raspisanie.TabIndex = 0;
            this.label_raspisanie.Text = "Расписание на";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1241, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label_back
            // 
            this.label_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_back.AutoSize = true;
            this.label_back.BackColor = System.Drawing.Color.Transparent;
            this.label_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_back.ForeColor = System.Drawing.Color.White;
            this.label_back.Location = new System.Drawing.Point(35, 12);
            this.label_back.Name = "label_back";
            this.label_back.Size = new System.Drawing.Size(63, 20);
            this.label_back.TabIndex = 3;
            this.label_back.Text = "Назад";
            this.label_back.Click += new System.EventHandler(this.label_back_Click);
            // 
            // Sessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Cinema_app_Diplom.Properties.Resources.Screenshot_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1404, 704);
            this.Controls.Add(this.label_back);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_raspisanie);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1420, 743);
            this.Name = "Sessions";
            this.Text = "Сеансы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sessions_FormClosed);
            this.Load += new System.EventHandler(this.Sessions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_raspisanie;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_back;
    }
}