
namespace Recreation_Center
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.ticketDetailsBtn = new System.Windows.Forms.Button();
            this.ticketBilingBtn = new System.Windows.Forms.Button();
            this.VisitorDetailsBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketDetailsBtn
            // 
            this.ticketDetailsBtn.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ticketDetailsBtn.Location = new System.Drawing.Point(28, 128);
            this.ticketDetailsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ticketDetailsBtn.Name = "ticketDetailsBtn";
            this.ticketDetailsBtn.Size = new System.Drawing.Size(214, 43);
            this.ticketDetailsBtn.TabIndex = 0;
            this.ticketDetailsBtn.Text = "Ticket Details";
            this.ticketDetailsBtn.UseVisualStyleBackColor = true;
            this.ticketDetailsBtn.Click += new System.EventHandler(this.ticketDetailsBtn_Click_1);
            // 
            // ticketBilingBtn
            // 
            this.ticketBilingBtn.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ticketBilingBtn.Location = new System.Drawing.Point(307, 128);
            this.ticketBilingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ticketBilingBtn.Name = "ticketBilingBtn";
            this.ticketBilingBtn.Size = new System.Drawing.Size(200, 43);
            this.ticketBilingBtn.TabIndex = 1;
            this.ticketBilingBtn.Text = "Ticket Billing";
            this.ticketBilingBtn.UseVisualStyleBackColor = true;
            this.ticketBilingBtn.Click += new System.EventHandler(this.VisitorDetailsBtn_Click_1);
            // 
            // VisitorDetailsBtn
            // 
            this.VisitorDetailsBtn.Location = new System.Drawing.Point(582, 128);
            this.VisitorDetailsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.VisitorDetailsBtn.Name = "VisitorDetailsBtn";
            this.VisitorDetailsBtn.Size = new System.Drawing.Size(196, 43);
            this.VisitorDetailsBtn.TabIndex = 2;
            this.VisitorDetailsBtn.Text = "Visitors Details";
            this.VisitorDetailsBtn.UseVisualStyleBackColor = true;
            this.VisitorDetailsBtn.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(918, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(317, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Recreation Center";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(986, 589);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VisitorDetailsBtn);
            this.Controls.Add(this.ticketBilingBtn);
            this.Controls.Add(this.ticketDetailsBtn);
            this.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ticketDetailsBtn;
        private System.Windows.Forms.Button ticketBilingBtn;
        private System.Windows.Forms.Button VisitorDetailsBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}