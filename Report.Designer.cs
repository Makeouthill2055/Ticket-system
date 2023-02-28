
namespace Recreation_Center
{
    partial class Report
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
            this.dayRep = new System.Windows.Forms.DataGridView();
            this.totalVisitors = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.weekRep = new System.Windows.Forms.DataGridView();
            this.weekChartBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dailyR_Btn = new System.Windows.Forms.Button();
            this.weeklyR_Btn = new System.Windows.Forms.Button();
            this.earningBtn = new System.Windows.Forms.Button();
            this.visitorBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dayRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekRep)).BeginInit();
            this.SuspendLayout();
            // 
            // dayRep
            // 
            this.dayRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dayRep.Location = new System.Drawing.Point(52, 142);
            this.dayRep.Name = "dayRep";
            this.dayRep.RowHeadersWidth = 51;
            this.dayRep.RowTemplate.Height = 24;
            this.dayRep.Size = new System.Drawing.Size(383, 245);
            this.dayRep.TabIndex = 0;
            // 
            // totalVisitors
            // 
            this.totalVisitors.Location = new System.Drawing.Point(962, 418);
            this.totalVisitors.Name = "totalVisitors";
            this.totalVisitors.ReadOnly = true;
            this.totalVisitors.Size = new System.Drawing.Size(116, 25);
            this.totalVisitors.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(680, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total No of Today Vistors:";
            // 
            // weekRep
            // 
            this.weekRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weekRep.Location = new System.Drawing.Point(599, 142);
            this.weekRep.Name = "weekRep";
            this.weekRep.RowHeadersWidth = 51;
            this.weekRep.RowTemplate.Height = 24;
            this.weekRep.Size = new System.Drawing.Size(502, 245);
            this.weekRep.TabIndex = 5;
            // 
            // weekChartBtn
            // 
            this.weekChartBtn.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weekChartBtn.Location = new System.Drawing.Point(438, 414);
            this.weekChartBtn.Name = "weekChartBtn";
            this.weekChartBtn.Size = new System.Drawing.Size(166, 37);
            this.weekChartBtn.TabIndex = 8;
            this.weekChartBtn.Text = "Weekly Chart";
            this.weekChartBtn.UseVisualStyleBackColor = true;
            this.weekChartBtn.Click += new System.EventHandler(this.weekChartBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.backBtn.Location = new System.Drawing.Point(329, 414);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(79, 37);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(186, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Daily Report";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(797, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Week Report";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(424, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Recreation Center";
            // 
            // dailyR_Btn
            // 
            this.dailyR_Btn.Location = new System.Drawing.Point(319, 68);
            this.dailyR_Btn.Name = "dailyR_Btn";
            this.dailyR_Btn.Size = new System.Drawing.Size(116, 23);
            this.dailyR_Btn.TabIndex = 13;
            this.dailyR_Btn.Text = "Daily Report";
            this.dailyR_Btn.UseVisualStyleBackColor = true;
            this.dailyR_Btn.Click += new System.EventHandler(this.dailyR_Btn_Click);
            // 
            // weeklyR_Btn
            // 
            this.weeklyR_Btn.Location = new System.Drawing.Point(696, 68);
            this.weeklyR_Btn.Name = "weeklyR_Btn";
            this.weeklyR_Btn.Size = new System.Drawing.Size(156, 23);
            this.weeklyR_Btn.TabIndex = 14;
            this.weeklyR_Btn.Text = "Weekly Report";
            this.weeklyR_Btn.UseVisualStyleBackColor = true;
            this.weeklyR_Btn.Click += new System.EventHandler(this.weeklyR_Btn_Click);
            // 
            // earningBtn
            // 
            this.earningBtn.Location = new System.Drawing.Point(1048, 68);
            this.earningBtn.Name = "earningBtn";
            this.earningBtn.Size = new System.Drawing.Size(83, 23);
            this.earningBtn.TabIndex = 15;
            this.earningBtn.Text = "Earning";
            this.earningBtn.UseVisualStyleBackColor = true;
            this.earningBtn.Click += new System.EventHandler(this.earningBtn_Click);
            // 
            // visitorBtn
            // 
            this.visitorBtn.Location = new System.Drawing.Point(941, 68);
            this.visitorBtn.Name = "visitorBtn";
            this.visitorBtn.Size = new System.Drawing.Size(81, 23);
            this.visitorBtn.TabIndex = 16;
            this.visitorBtn.Text = "Visitor";
            this.visitorBtn.UseVisualStyleBackColor = true;
            this.visitorBtn.Click += new System.EventHandler(this.visitorBtn_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1167, 451);
            this.Controls.Add(this.visitorBtn);
            this.Controls.Add(this.earningBtn);
            this.Controls.Add(this.weeklyR_Btn);
            this.Controls.Add(this.dailyR_Btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.weekChartBtn);
            this.Controls.Add(this.weekRep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalVisitors);
            this.Controls.Add(this.dayRep);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dayRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekRep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dayRep;
        private System.Windows.Forms.TextBox totalVisitors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView weekRep;
        private System.Windows.Forms.Button weekChartBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dailyR_Btn;
        private System.Windows.Forms.Button weeklyR_Btn;
        private System.Windows.Forms.Button earningBtn;
        private System.Windows.Forms.Button visitorBtn;
    }
}