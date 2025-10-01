namespace ATMTuto
{
    partial class Home
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
            LOCIN = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel2 = new Panel();
            label6 = new Label();
            AccNumlbl = new Label();
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
            panel1.Size = new Size(867, 136);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateGray;
            label2.Font = new Font("Monospac821 BT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(826, 0);
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
            label1.Location = new Point(111, 43);
            label1.Name = "label1";
            label1.Size = new Size(679, 43);
            label1.TabIndex = 2;
            label1.Text = "Select Your Transaction Please";
            // 
            // LOCIN
            // 
            LOCIN.BackColor = Color.DarkSlateGray;
            LOCIN.ForeColor = Color.White;
            LOCIN.Location = new Point(45, 205);
            LOCIN.Name = "LOCIN";
            LOCIN.Size = new Size(242, 50);
            LOCIN.TabIndex = 9;
            LOCIN.Text = "DEPOSIT";
            LOCIN.UseVisualStyleBackColor = false;
            LOCIN.Click += LOCIN_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = Color.White;
            button1.Location = new Point(548, 205);
            button1.Name = "button1";
            button1.Size = new Size(242, 50);
            button1.TabIndex = 10;
            button1.Text = "WITHDRAW";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.ForeColor = Color.White;
            button2.Location = new Point(45, 334);
            button2.Name = "button2";
            button2.Size = new Size(242, 50);
            button2.TabIndex = 11;
            button2.Text = "FAST CASH";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSlateGray;
            button3.ForeColor = Color.White;
            button3.Location = new Point(548, 334);
            button3.Name = "button3";
            button3.Size = new Size(242, 50);
            button3.TabIndex = 12;
            button3.Text = "MINI STATEMENT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSlateGray;
            button4.ForeColor = Color.White;
            button4.Location = new Point(45, 448);
            button4.Name = "button4";
            button4.Size = new Size(242, 50);
            button4.TabIndex = 13;
            button4.Text = "CHANGE PIN";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSlateGray;
            button5.ForeColor = Color.White;
            button5.Location = new Point(548, 448);
            button5.Name = "button5";
            button5.Size = new Size(242, 50);
            button5.TabIndex = 14;
            button5.Text = "BALANCE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 617);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 18);
            panel2.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Monospac821 BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(353, 544);
            label6.Name = "label6";
            label6.Size = new Size(97, 29);
            label6.TabIndex = 47;
            label6.Text = "LOGOUT";
            label6.Click += label6_Click;
            // 
            // AccNumlbl
            // 
            AccNumlbl.AutoSize = true;
            AccNumlbl.BackColor = Color.White;
            AccNumlbl.Font = new Font("Monospac821 BT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccNumlbl.ForeColor = SystemColors.WindowFrame;
            AccNumlbl.Location = new Point(254, 139);
            AccNumlbl.Name = "AccNumlbl";
            AccNumlbl.Size = new Size(327, 43);
            AccNumlbl.TabIndex = 4;
            AccNumlbl.Text = "Account Number";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 635);
            Controls.Add(AccNumlbl);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(LOCIN);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HOME";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button LOCIN;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel2;
        private Label label6;
        private Label AccNumlbl;
    }
}