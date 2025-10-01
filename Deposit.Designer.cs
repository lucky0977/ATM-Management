namespace ATMTuto
{
    partial class Deposit
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
            DepoAmtTb = new TextBox();
            label13 = new Label();
            LOCIN = new Button();
            label6 = new Label();
            panel2 = new Panel();
            label3 = new Label();
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
            panel1.Size = new Size(934, 148);
            panel1.TabIndex = 3;
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
            label1.Click += label1_Click;
            // 
            // DepoAmtTb
            // 
            DepoAmtTb.Font = new Font("Monospac821 BT", 14F, FontStyle.Bold);
            DepoAmtTb.Location = new Point(426, 271);
            DepoAmtTb.Name = "DepoAmtTb";
            DepoAmtTb.Size = new Size(242, 41);
            DepoAmtTb.TabIndex = 44;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.Font = new Font("Monospac821 BT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(223, 278);
            label13.Name = "label13";
            label13.Size = new Size(134, 34);
            label13.TabIndex = 43;
            label13.Text = "AMOUNT:";
            label13.Click += label13_Click;
            // 
            // LOCIN
            // 
            LOCIN.BackColor = Color.DarkSlateGray;
            LOCIN.ForeColor = Color.White;
            LOCIN.Location = new Point(426, 385);
            LOCIN.Name = "LOCIN";
            LOCIN.Size = new Size(242, 50);
            LOCIN.TabIndex = 45;
            LOCIN.Text = "DEPOSIT";
            LOCIN.UseVisualStyleBackColor = false;
            LOCIN.Click += LOCIN_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Monospac821 BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(490, 474);
            label6.Name = "label6";
            label6.Size = new Size(69, 29);
            label6.TabIndex = 46;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 599);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 14);
            panel2.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Monospac821 BT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(371, 161);
            label3.Name = "label3";
            label3.Size = new Size(134, 34);
            label3.TabIndex = 48;
            label3.Text = "DEPOSIT";
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 613);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(LOCIN);
            Controls.Add(DepoAmtTb);
            Controls.Add(label13);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Deposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposit";
            Load += Deposit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox DepoAmtTb;
        private Label label13;
        private Button LOCIN;
        private Label label6;
        private Panel panel2;
        private Label label3;
    }
}