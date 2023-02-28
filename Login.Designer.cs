
namespace Recreation_Center
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adCan = new System.Windows.Forms.Button();
            this.adsub = new System.Windows.Forms.Button();
            this.checkBox_adShowPw = new System.Windows.Forms.CheckBox();
            this.adPw = new System.Windows.Forms.TextBox();
            this.adUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.stSub = new System.Windows.Forms.Button();
            this.stCan = new System.Windows.Forms.Button();
            this.checkBox_stShowPw = new System.Windows.Forms.CheckBox();
            this.stPw = new System.Windows.Forms.TextBox();
            this.stUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(221, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.adCan);
            this.tabPage1.Controls.Add(this.adsub);
            this.tabPage1.Controls.Add(this.checkBox_adShowPw);
            this.tabPage1.Controls.Add(this.adPw);
            this.tabPage1.Controls.Add(this.adUser);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(440, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // adCan
            // 
            this.adCan.Font = new System.Drawing.Font("PMingLiU", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.adCan.Location = new System.Drawing.Point(223, 351);
            this.adCan.Name = "adCan";
            this.adCan.Size = new System.Drawing.Size(88, 31);
            this.adCan.TabIndex = 13;
            this.adCan.Text = "Cancel";
            this.adCan.UseVisualStyleBackColor = true;
            this.adCan.Click += new System.EventHandler(this.adCan_Click);
            // 
            // adsub
            // 
            this.adsub.Font = new System.Drawing.Font("PMingLiU", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.adsub.Location = new System.Drawing.Point(115, 351);
            this.adsub.Name = "adsub";
            this.adsub.Size = new System.Drawing.Size(81, 31);
            this.adsub.TabIndex = 7;
            this.adsub.Text = "Submit";
            this.adsub.UseVisualStyleBackColor = true;
            this.adsub.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox_adShowPw
            // 
            this.checkBox_adShowPw.AutoSize = true;
            this.checkBox_adShowPw.Location = new System.Drawing.Point(120, 306);
            this.checkBox_adShowPw.Name = "checkBox_adShowPw";
            this.checkBox_adShowPw.Size = new System.Drawing.Size(131, 19);
            this.checkBox_adShowPw.TabIndex = 12;
            this.checkBox_adShowPw.Text = "Show Password";
            this.checkBox_adShowPw.UseVisualStyleBackColor = true;
            this.checkBox_adShowPw.CheckedChanged += new System.EventHandler(this.checkBox_adShowPw_CheckedChanged);
            // 
            // adPw
            // 
            this.adPw.Location = new System.Drawing.Point(120, 260);
            this.adPw.Name = "adPw";
            this.adPw.Size = new System.Drawing.Size(178, 25);
            this.adPw.TabIndex = 11;
            this.adPw.UseSystemPasswordChar = true;
            // 
            // adUser
            // 
            this.adUser.Location = new System.Drawing.Point(120, 182);
            this.adUser.Name = "adUser";
            this.adUser.Size = new System.Drawing.Size(179, 25);
            this.adUser.TabIndex = 10;
            this.adUser.TextChanged += new System.EventHandler(this.adUser_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(117, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(117, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.stSub);
            this.tabPage2.Controls.Add(this.stCan);
            this.tabPage2.Controls.Add(this.checkBox_stShowPw);
            this.tabPage2.Controls.Add(this.stPw);
            this.tabPage2.Controls.Add(this.stUser);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Font = new System.Drawing.Font("PMingLiU", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(440, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Staff";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(110, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // stSub
            // 
            this.stSub.Location = new System.Drawing.Point(99, 366);
            this.stSub.Name = "stSub";
            this.stSub.Size = new System.Drawing.Size(85, 30);
            this.stSub.TabIndex = 8;
            this.stSub.Text = "Submit";
            this.stSub.UseVisualStyleBackColor = true;
            this.stSub.Click += new System.EventHandler(this.button5_Click);
            // 
            // stCan
            // 
            this.stCan.Location = new System.Drawing.Point(213, 366);
            this.stCan.Name = "stCan";
            this.stCan.Size = new System.Drawing.Size(84, 30);
            this.stCan.TabIndex = 7;
            this.stCan.Text = "Cancel";
            this.stCan.UseVisualStyleBackColor = true;
            this.stCan.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox_stShowPw
            // 
            this.checkBox_stShowPw.AutoSize = true;
            this.checkBox_stShowPw.Location = new System.Drawing.Point(109, 320);
            this.checkBox_stShowPw.Name = "checkBox_stShowPw";
            this.checkBox_stShowPw.Size = new System.Drawing.Size(145, 21);
            this.checkBox_stShowPw.TabIndex = 6;
            this.checkBox_stShowPw.Text = "Show Password";
            this.checkBox_stShowPw.UseVisualStyleBackColor = true;
            this.checkBox_stShowPw.CheckedChanged += new System.EventHandler(this.checkBox_stShowPw_CheckedChanged);
            // 
            // stPw
            // 
            this.stPw.Location = new System.Drawing.Point(109, 274);
            this.stPw.Name = "stPw";
            this.stPw.Size = new System.Drawing.Size(178, 28);
            this.stPw.TabIndex = 11;
            this.stPw.UseSystemPasswordChar = true;
            this.stPw.TextChanged += new System.EventHandler(this.stPw_TextChanged);
            // 
            // stUser
            // 
            this.stUser.Location = new System.Drawing.Point(109, 196);
            this.stUser.Name = "stUser";
            this.stUser.Size = new System.Drawing.Size(179, 28);
            this.stUser.TabIndex = 4;
            this.stUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(106, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(106, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(972, 555);
            this.Controls.Add(this.tabControl1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button adsub;
        private System.Windows.Forms.CheckBox checkBox_adShowPw;
        private System.Windows.Forms.TextBox adPw;
        private System.Windows.Forms.TextBox adUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_stShowPw;
        private System.Windows.Forms.TextBox stPw;
        private System.Windows.Forms.TextBox stUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stCan;
        private System.Windows.Forms.Button adCan;
        private System.Windows.Forms.Button stSub;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}