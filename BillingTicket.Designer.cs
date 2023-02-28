
namespace Recreation_Center
{
    partial class BillingTicket
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
            this.components = new System.ComponentModel.Container();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.checkoutTime_box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.durationHrs = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.ComboBox();
            this.adult_radioButton = new System.Windows.Forms.RadioButton();
            this.child_radioButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contactBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.age_resetBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TotalPrice
            // 
            this.TotalPrice.Location = new System.Drawing.Point(539, 297);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(135, 25);
            this.TotalPrice.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(417, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 48;
            this.label11.Text = "Total Price";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(599, 363);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 30);
            this.saveBtn.TabIndex = 47;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // checkoutTime_box
            // 
            this.checkoutTime_box.Location = new System.Drawing.Point(539, 244);
            this.checkoutTime_box.Name = "checkoutTime_box";
            this.checkoutTime_box.ReadOnly = true;
            this.checkoutTime_box.Size = new System.Drawing.Size(135, 25);
            this.checkoutTime_box.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(414, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 15);
            this.label10.TabIndex = 45;
            this.label10.Text = "Checkout Time";
            // 
            // durationHrs
            // 
            this.durationHrs.FormattingEnabled = true;
            this.durationHrs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "Whole Day"});
            this.durationHrs.Location = new System.Drawing.Point(539, 193);
            this.durationHrs.Name = "durationHrs";
            this.durationHrs.Size = new System.Drawing.Size(135, 23);
            this.durationHrs.TabIndex = 44;
            this.durationHrs.Text = "Hours";
            this.durationHrs.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 43;
            this.label9.Text = "Duration";
            // 
            // groupBox
            // 
            this.groupBox.FormattingEnabled = true;
            this.groupBox.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.groupBox.Location = new System.Drawing.Point(539, 86);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(135, 23);
            this.groupBox.TabIndex = 42;
            this.groupBox.Text = "Group of";
            this.groupBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // adult_radioButton
            // 
            this.adult_radioButton.AutoSize = true;
            this.adult_radioButton.Location = new System.Drawing.Point(539, 161);
            this.adult_radioButton.Name = "adult_radioButton";
            this.adult_radioButton.Size = new System.Drawing.Size(104, 19);
            this.adult_radioButton.TabIndex = 41;
            this.adult_radioButton.TabStop = true;
            this.adult_radioButton.Text = "Adult ( >12 )";
            this.adult_radioButton.UseVisualStyleBackColor = true;
            this.adult_radioButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // child_radioButton
            // 
            this.child_radioButton.AutoSize = true;
            this.child_radioButton.Location = new System.Drawing.Point(539, 136);
            this.child_radioButton.Name = "child_radioButton";
            this.child_radioButton.Size = new System.Drawing.Size(99, 19);
            this.child_radioButton.TabIndex = 40;
            this.child_radioButton.TabStop = true;
            this.child_radioButton.Text = "Child (5-12)";
            this.child_radioButton.UseVisualStyleBackColor = true;
            this.child_radioButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "Group";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "Age";
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(196, 346);
            this.timeBox.Name = "timeBox";
            this.timeBox.ReadOnly = true;
            this.timeBox.Size = new System.Drawing.Size(141, 25);
            this.timeBox.TabIndex = 37;
            // 
            // dayBox
            // 
            this.dayBox.Location = new System.Drawing.Point(196, 292);
            this.dayBox.Name = "dayBox";
            this.dayBox.ReadOnly = true;
            this.dayBox.Size = new System.Drawing.Size(141, 25);
            this.dayBox.TabIndex = 36;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(196, 240);
            this.dateBox.Name = "dateBox";
            this.dateBox.ReadOnly = true;
            this.dateBox.Size = new System.Drawing.Size(141, 25);
            this.dateBox.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Date";
            // 
            // contactBox
            // 
            this.contactBox.Location = new System.Drawing.Point(196, 191);
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(141, 25);
            this.contactBox.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Contact";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(196, 140);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(141, 25);
            this.nameBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Name";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(196, 92);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(89, 25);
            this.idBox.TabIndex = 27;
            this.idBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // age_resetBtn
            // 
            this.age_resetBtn.Location = new System.Drawing.Point(660, 140);
            this.age_resetBtn.Name = "age_resetBtn";
            this.age_resetBtn.Size = new System.Drawing.Size(143, 35);
            this.age_resetBtn.TabIndex = 50;
            this.age_resetBtn.Text = "Reset Age - Group";
            this.age_resetBtn.UseVisualStyleBackColor = true;
            this.age_resetBtn.Click += new System.EventHandler(this.age_resetBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(495, 363);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(78, 30);
            this.backBtn.TabIndex = 52;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(318, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 24);
            this.label12.TabIndex = 53;
            this.label12.Text = "Recreation Center";
            // 
            // BillingTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(901, 422);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.age_resetBtn);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.checkoutTime_box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.durationHrs);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.adult_radioButton);
            this.Controls.Add(this.child_radioButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contactBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label1);
            this.Name = "BillingTicket";
            this.Text = "BillingTicket";
            this.Load += new System.EventHandler(this.BillingTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TotalPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox checkoutTime_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox durationHrs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox groupBox;
        private System.Windows.Forms.RadioButton adult_radioButton;
        private System.Windows.Forms.RadioButton child_radioButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contactBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button age_resetBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label12;
    }
}