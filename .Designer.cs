
namespace Recreation_Center
{
    partial class SetTicketPrice
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
            this.label1 = new System.Windows.Forms.Label();
            this.day_comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioA_btn = new System.Windows.Forms.RadioButton();
            this.radioC_btn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.setPrice_btn = new System.Windows.Forms.Button();
            this.price1hr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.price2hrs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.price3hrs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.price4hrs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.priceWholeDay = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Day";
            // 
            // day_comboBox1
            // 
            this.day_comboBox1.FormattingEnabled = true;
            this.day_comboBox1.Items.AddRange(new object[] {
            "Weekday",
            "Holiday"});
            this.day_comboBox1.Location = new System.Drawing.Point(316, 74);
            this.day_comboBox1.Name = "day_comboBox1";
            this.day_comboBox1.Size = new System.Drawing.Size(227, 23);
            this.day_comboBox1.TabIndex = 1;
            this.day_comboBox1.Text = "Select  Day Type";
            this.day_comboBox1.SelectedIndexChanged += new System.EventHandler(this.day_comboBox1_SelectedIndexChanged);
            // 
            // radioA_btn
            // 
            this.radioA_btn.AutoSize = true;
            this.radioA_btn.Location = new System.Drawing.Point(313, 143);
            this.radioA_btn.Name = "radioA_btn";
            this.radioA_btn.Size = new System.Drawing.Size(108, 19);
            this.radioA_btn.TabIndex = 4;
            this.radioA_btn.TabStop = true;
            this.radioA_btn.Text = "Adult ( > 12 )";
            this.radioA_btn.UseVisualStyleBackColor = true;
            this.radioA_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // radioC_btn
            // 
            this.radioC_btn.AutoSize = true;
            this.radioC_btn.Location = new System.Drawing.Point(313, 118);
            this.radioC_btn.Name = "radioC_btn";
            this.radioC_btn.Size = new System.Drawing.Size(107, 19);
            this.radioC_btn.TabIndex = 3;
            this.radioC_btn.TabStop = true;
            this.radioC_btn.Text = "Child (5 - 12)";
            this.radioC_btn.UseVisualStyleBackColor = true;
            this.radioC_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "age ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "group";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.comboBox2.Location = new System.Drawing.Point(316, 181);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(78, 23);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.Text = "Group of";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "1 Hour Price";
            // 
            // setPrice_btn
            // 
            this.setPrice_btn.Location = new System.Drawing.Point(313, 452);
            this.setPrice_btn.Name = "setPrice_btn";
            this.setPrice_btn.Size = new System.Drawing.Size(111, 31);
            this.setPrice_btn.TabIndex = 23;
            this.setPrice_btn.Text = "Set Price";
            this.setPrice_btn.UseVisualStyleBackColor = true;
            this.setPrice_btn.Click += new System.EventHandler(this.setPrice_btn_Click);
            // 
            // price1hr
            // 
            this.price1hr.Location = new System.Drawing.Point(316, 229);
            this.price1hr.Name = "price1hr";
            this.price1hr.Size = new System.Drawing.Size(78, 25);
            this.price1hr.TabIndex = 24;
            this.price1hr.TextChanged += new System.EventHandler(this.price1hr_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "2 Hour Price";
            // 
            // price2hrs
            // 
            this.price2hrs.Location = new System.Drawing.Point(316, 273);
            this.price2hrs.Name = "price2hrs";
            this.price2hrs.Size = new System.Drawing.Size(78, 25);
            this.price2hrs.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "3 Hour Price";
            // 
            // price3hrs
            // 
            this.price3hrs.Location = new System.Drawing.Point(316, 315);
            this.price3hrs.Name = "price3hrs";
            this.price3hrs.Size = new System.Drawing.Size(78, 25);
            this.price3hrs.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "4 Hour Price";
            // 
            // price4hrs
            // 
            this.price4hrs.Location = new System.Drawing.Point(316, 358);
            this.price4hrs.Name = "price4hrs";
            this.price4hrs.Size = new System.Drawing.Size(78, 25);
            this.price4hrs.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "Whole Day Price";
            // 
            // priceWholeDay
            // 
            this.priceWholeDay.Location = new System.Drawing.Point(316, 401);
            this.priceWholeDay.Name = "priceWholeDay";
            this.priceWholeDay.Size = new System.Drawing.Size(78, 25);
            this.priceWholeDay.TabIndex = 32;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(441, 123);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(143, 73);
            this.resetBtn.TabIndex = 33;
            this.resetBtn.Text = "Reset Age - Group";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(466, 452);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(77, 31);
            this.backBtn.TabIndex = 34;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(277, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 24);
            this.label9.TabIndex = 35;
            this.label9.Text = "Recreation Center";
            // 
            // SetTicketPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.priceWholeDay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.price4hrs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.price3hrs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.price2hrs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.price1hr);
            this.Controls.Add(this.setPrice_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioA_btn);
            this.Controls.Add(this.radioC_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.day_comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "SetTicketPrice";
            this.RightToLeftLayout = true;
            this.Text = "SetTicketPrice";
            this.Load += new System.EventHandler(this.SetTicketPrice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox day_comboBox1;
        private System.Windows.Forms.RadioButton radioA_btn;
        private System.Windows.Forms.RadioButton radioC_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button setPrice_btn;
        private System.Windows.Forms.TextBox price1hr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price2hrs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox price3hrs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox price4hrs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox priceWholeDay;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label9;
    }
}

