namespace ATMTuto
{
    partial class account
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            AccNametb = new TextBox();
            AccNumTb = new TextBox();
            Addresstb = new TextBox();
            FanameTb = new TextBox();
            pintb = new TextBox();
            PhoneTb = new TextBox();
            educationcb = new ComboBox();
            dobdate = new DateTimePicker();
            button11 = new Button();
            panel2 = new Panel();
            label6 = new Label();
            occupationtb = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1275, 136);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateGray;
            label2.Font = new Font("Monospac821 BT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1231, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 43);
            label2.TabIndex = 3;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.Font = new Font("Monospac821 BT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(317, 49);
            label1.Name = "label1";
            label1.Size = new Size(481, 43);
            label1.TabIndex = 2;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(166, 311);
            button2.Name = "button2";
            button2.Size = new Size(144, 41);
            button2.TabIndex = 10;
            button2.Text = "ACC NUM";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(166, 403);
            button1.Name = "button1";
            button1.Size = new Size(144, 41);
            button1.TabIndex = 11;
            button1.Text = "NAME";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.DarkSlateGray;
            button3.Location = new Point(166, 494);
            button3.Name = "button3";
            button3.Size = new Size(144, 41);
            button3.TabIndex = 12;
            button3.Text = "FNAME";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.DarkSlateGray;
            button4.Location = new Point(166, 584);
            button4.Name = "button4";
            button4.Size = new Size(144, 41);
            button4.TabIndex = 13;
            button4.Text = "ADDRESS";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Control;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.DarkSlateGray;
            button5.Location = new Point(673, 579);
            button5.Name = "button5";
            button5.Size = new Size(144, 41);
            button5.TabIndex = 14;
            button5.Text = "PHONE";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Control;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.DarkSlateGray;
            button6.Location = new Point(673, 676);
            button6.Name = "button6";
            button6.Size = new Size(125, 41);
            button6.TabIndex = 15;
            button6.Text = "DOB";
            button6.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.Control;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.DarkSlateGray;
            button8.Location = new Point(673, 398);
            button8.Name = "button8";
            button8.Size = new Size(162, 41);
            button8.TabIndex = 17;
            button8.Text = "EDUCATION";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.Control;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.DarkSlateGray;
            button9.Location = new Point(673, 489);
            button9.Name = "button9";
            button9.Size = new Size(181, 41);
            button9.TabIndex = 18;
            button9.Text = "OCCUPATION";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.Control;
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.DarkSlateGray;
            button10.Location = new Point(673, 311);
            button10.Name = "button10";
            button10.Size = new Size(144, 41);
            button10.TabIndex = 19;
            button10.Text = "PIN";
            button10.UseVisualStyleBackColor = false;
            // 
            // AccNametb
            // 
            AccNametb.Font = new Font("Monospac821 BT", 16F, FontStyle.Bold);
            AccNametb.Location = new Point(349, 398);
            AccNametb.Name = "AccNametb";
            AccNametb.Size = new Size(227, 46);
            AccNametb.TabIndex = 21;
            // 
            // AccNumTb
            // 
            AccNumTb.Font = new Font("Monospac821 BT", 16F, FontStyle.Bold);
            AccNumTb.Location = new Point(349, 306);
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(227, 46);
            AccNumTb.TabIndex = 20;
            // 
            // Addresstb
            // 
            Addresstb.Font = new Font("Monospac821 BT", 16F, FontStyle.Bold);
            Addresstb.Location = new Point(349, 579);
            Addresstb.Multiline = true;
            Addresstb.Name = "Addresstb";
            Addresstb.Size = new Size(227, 138);
            Addresstb.TabIndex = 23;
            // 
            // FanameTb
            // 
            FanameTb.Font = new Font("Monospac821 BT", 16F, FontStyle.Bold);
            FanameTb.Location = new Point(349, 489);
            FanameTb.Name = "FanameTb";
            FanameTb.Size = new Size(227, 46);
            FanameTb.TabIndex = 22;
            // 
            // pintb
            // 
            pintb.Font = new Font("Monospac821 BT", 16F, FontStyle.Bold);
            pintb.Location = new Point(886, 306);
            pintb.Name = "pintb";
            pintb.Size = new Size(227, 46);
            pintb.TabIndex = 24;
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Monospac821 BT", 16F, FontStyle.Bold);
            PhoneTb.Location = new Point(887, 579);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(227, 46);
            PhoneTb.TabIndex = 26;
            // 
            // educationcb
            // 
            educationcb.Font = new Font("Monospac821 BT", 16F, FontStyle.Bold);
            educationcb.FormattingEnabled = true;
            educationcb.Items.AddRange(new object[] { "Non Graduate", "Under Graduate", "Post Graduate" });
            educationcb.Location = new Point(886, 397);
            educationcb.Name = "educationcb";
            educationcb.Size = new Size(227, 47);
            educationcb.TabIndex = 28;
            // 
            // dobdate
            // 
            dobdate.Font = new Font("Monospac821 BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dobdate.Location = new Point(887, 673);
            dobdate.Name = "dobdate";
            dobdate.Size = new Size(226, 36);
            dobdate.TabIndex = 30;
            // 
            // button11
            // 
            button11.BackColor = Color.DarkSlateGray;
            button11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.White;
            button11.Location = new Point(534, 780);
            button11.Name = "button11";
            button11.Size = new Size(216, 51);
            button11.TabIndex = 31;
            button11.Text = "Submit";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 920);
            panel2.Name = "panel2";
            panel2.Size = new Size(1275, 24);
            panel2.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Monospac821 BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(589, 845);
            label6.Name = "label6";
            label6.Size = new Size(97, 29);
            label6.TabIndex = 48;
            label6.Text = "LOGOUT";
            label6.Click += label6_Click;
            // 
            // occupationtb
            // 
            occupationtb.Font = new Font("Monospac821 BT", 16F, FontStyle.Bold);
            occupationtb.Location = new Point(886, 490);
            occupationtb.Name = "occupationtb";
            occupationtb.Size = new Size(227, 46);
            occupationtb.TabIndex = 49;
            // 
            // account
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 944);
            Controls.Add(occupationtb);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(button11);
            Controls.Add(dobdate);
            Controls.Add(educationcb);
            Controls.Add(PhoneTb);
            Controls.Add(pintb);
            Controls.Add(Addresstb);
            Controls.Add(FanameTb);
            Controls.Add(AccNametb);
            Controls.Add(AccNumTb);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "account";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button9;
        private Button button10;
        private TextBox AccNametb;
        private TextBox AccNumTb;
        private TextBox Addresstb;
        private TextBox FanameTb;
        private TextBox pintb;
        private TextBox PhoneTb;
        private ComboBox educationcb;
        private DateTimePicker dobdate;
        private Button button11;
        private Panel panel2;
        private Label label6;
        private TextBox occupationtb;
    }
}