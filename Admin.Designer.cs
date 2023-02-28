
namespace Recreation_Center
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.setTicketBtn = new System.Windows.Forms.Button();
            this.daily_weeklyRep = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // setTicketBtn
            // 
            this.setTicketBtn.BackColor = System.Drawing.Color.Transparent;
            this.setTicketBtn.Location = new System.Drawing.Point(147, 89);
            this.setTicketBtn.Margin = new System.Windows.Forms.Padding(4);
            this.setTicketBtn.Name = "setTicketBtn";
            this.setTicketBtn.Size = new System.Drawing.Size(204, 55);
            this.setTicketBtn.TabIndex = 0;
            this.setTicketBtn.Text = "Set Ticket Prices";
            this.setTicketBtn.UseVisualStyleBackColor = false;
            this.setTicketBtn.Click += new System.EventHandler(this.setTicketBtn_Click);
            // 
            // daily_weeklyRep
            // 
            this.daily_weeklyRep.Location = new System.Drawing.Point(489, 89);
            this.daily_weeklyRep.Margin = new System.Windows.Forms.Padding(4);
            this.daily_weeklyRep.Name = "daily_weeklyRep";
            this.daily_weeklyRep.Size = new System.Drawing.Size(199, 55);
            this.daily_weeklyRep.TabIndex = 4;
            this.daily_weeklyRep.Text = "Daily-Weekly Report";
            this.daily_weeklyRep.UseVisualStyleBackColor = true;
            this.daily_weeklyRep.Click += new System.EventHandler(this.daily_weeklyRep_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(841, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(288, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Recreation Center";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(919, 609);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.daily_weeklyRep);
            this.Controls.Add(this.setTicketBtn);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setTicketBtn;
        private System.Windows.Forms.Button daily_weeklyRep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}