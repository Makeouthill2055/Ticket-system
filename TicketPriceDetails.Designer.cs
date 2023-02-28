
namespace Recreation_Center
{
    partial class TicketPriceDetails
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
            this.ticketPrice = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticketPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketPrice
            // 
            this.ticketPrice.BackgroundColor = System.Drawing.Color.Gray;
            this.ticketPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketPrice.Location = new System.Drawing.Point(28, 78);
            this.ticketPrice.Name = "ticketPrice";
            this.ticketPrice.RowHeadersWidth = 51;
            this.ticketPrice.RowTemplate.Height = 24;
            this.ticketPrice.Size = new System.Drawing.Size(1131, 417);
            this.ticketPrice.TabIndex = 0;
            this.ticketPrice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketPrice_CellContentClick);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.backBtn.Location = new System.Drawing.Point(601, 512);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 35);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(540, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Recreation Center";
            // 
            // TicketPriceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1188, 563);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.ticketPrice);
            this.Name = "TicketPriceDetails";
            this.Text = "s";
            this.Load += new System.EventHandler(this.TicketPriceDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ticketPrice;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label4;
    }
}