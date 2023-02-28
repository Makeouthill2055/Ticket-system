
namespace Recreation_Center
{
    partial class Visitor_Details
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
            this.visitorDetailsGrid = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visitorDetailsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // visitorDetailsGrid
            // 
            this.visitorDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitorDetailsGrid.Location = new System.Drawing.Point(21, 92);
            this.visitorDetailsGrid.Name = "visitorDetailsGrid";
            this.visitorDetailsGrid.RowHeadersWidth = 51;
            this.visitorDetailsGrid.RowTemplate.Height = 24;
            this.visitorDetailsGrid.Size = new System.Drawing.Size(1662, 430);
            this.visitorDetailsGrid.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("PMingLiU", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.backBtn.Location = new System.Drawing.Point(758, 528);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 30);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(696, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Recreation Center";
            // 
            // Visitor_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1710, 564);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.visitorDetailsGrid);
            this.Name = "Visitor_Details";
            this.Text = "Visitor_Details";
            this.Load += new System.EventHandler(this.Visitor_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visitorDetailsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView visitorDetailsGrid;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label4;
    }
}