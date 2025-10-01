namespace ATMTuto
{
    partial class withdraw
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
            label3 = new Label();
            label6 = new Label();
            LOCIN = new Button();
            wdamtTb = new TextBox();
            label13 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            balancelbl = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Monospac821 BT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(383, 190);
            label3.Name = "label3";
            label3.Size = new Size(151, 34);
            label3.TabIndex = 53;
            label3.Text = "WITHDRAW";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Monospac821 BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(447, 521);
            label6.Name = "label6";
            label6.Size = new Size(97, 29);
            label6.TabIndex = 52;
            label6.Text = "LOGOUT";
            label6.Click += label6_Click;
            // 
            // LOCIN
            // 
            LOCIN.BackColor = Color.DarkSlateGray;
            LOCIN.ForeColor = Color.White;
            LOCIN.Location = new Point(383, 458);
            LOCIN.Name = "LOCIN";
            LOCIN.Size = new Size(242, 50);
            LOCIN.TabIndex = 51;
            LOCIN.Text = "WITHDRAW";
            LOCIN.UseVisualStyleBackColor = false;
            LOCIN.Click += LOCIN_Click;
            // 
            // wdamtTb
            // 
            wdamtTb.Font = new Font("Monospac821 BT", 14F, FontStyle.Bold);
            wdamtTb.Location = new Point(447, 395);
            wdamtTb.Name = "wdamtTb";
            wdamtTb.Size = new Size(242, 41);
            wdamtTb.TabIndex = 50;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.Font = new Font("Monospac821 BT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(218, 398);
            label13.Name = "label13";
            label13.Size = new Size(117, 34);
            label13.TabIndex = 49;
            label13.Text = "AMOUNT";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 148);
            panel1.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateGray;
            label2.Font = new Font("Monospac821 BT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(893, 0);
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
            label1.Location = new Point(202, 50);
            label1.Name = "label1";
            label1.Size = new Size(481, 43);
            label1.TabIndex = 2;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // balancelbl
            // 
            balancelbl.AutoSize = true;
            balancelbl.Enabled = false;
            balancelbl.Font = new Font("Monospac821 BT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            balancelbl.ForeColor = Color.DarkSlateGray;
            balancelbl.Location = new Point(357, 316);
            balancelbl.Name = "balancelbl";
            balancelbl.Size = new Size(304, 34);
            balancelbl.TabIndex = 55;
            balancelbl.Text = "AVAILABLE BALANCE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 598);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 15);
            panel2.TabIndex = 56;
            // 
            // withdraw
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 613);
            Controls.Add(panel2);
            Controls.Add(balancelbl);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(LOCIN);
            Controls.Add(wdamtTb);
            Controls.Add(label13);
            FormBorderStyle = FormBorderStyle.None;
            Name = "withdraw";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "withdraw";
            Load += withdraw_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label6;
        private Button LOCIN;
        private TextBox wdamtTb;
        private Label label13;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label balancelbl;
        private Panel panel2;
    }
}