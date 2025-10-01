namespace ATMTuto
{
    partial class Balance
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
            label13 = new Label();
            label3 = new Label();
            Balancelbl = new Label();
            AccNumberlbl = new Label();
            panel2 = new Panel();
            label6 = new Label();
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
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
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
            label1.Location = new Point(214, 58);
            label1.Name = "label1";
            label1.Size = new Size(481, 43);
            label1.TabIndex = 2;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.Font = new Font("Monospac821 BT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(212, 261);
            label13.Name = "label13";
            label13.Size = new Size(270, 34);
            label13.TabIndex = 36;
            label13.Text = "Account Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Monospac821 BT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(212, 360);
            label3.Name = "label3";
            label3.Size = new Size(236, 34);
            label3.TabIndex = 37;
            label3.Text = "Your Balance:";
            // 
            // Balancelbl
            // 
            Balancelbl.AutoSize = true;
            Balancelbl.BackColor = SystemColors.Control;
            Balancelbl.Font = new Font("Monospac821 BT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Balancelbl.ForeColor = Color.DarkSlateGray;
            Balancelbl.Location = new Point(493, 360);
            Balancelbl.Name = "Balancelbl";
            Balancelbl.Size = new Size(202, 34);
            Balancelbl.TabIndex = 39;
            Balancelbl.Text = "BalanceinRs";
            // 
            // AccNumberlbl
            // 
            AccNumberlbl.AutoSize = true;
            AccNumberlbl.BackColor = SystemColors.Control;
            AccNumberlbl.Font = new Font("Monospac821 BT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccNumberlbl.ForeColor = Color.DarkSlateGray;
            AccNumberlbl.Location = new Point(493, 261);
            AccNumberlbl.Name = "AccNumberlbl";
            AccNumberlbl.Size = new Size(117, 34);
            AccNumberlbl.TabIndex = 38;
            AccNumberlbl.Text = "AccNum";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 596);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 17);
            panel2.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Monospac821 BT", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(408, 544);
            label6.Name = "label6";
            label6.Size = new Size(93, 39);
            label6.TabIndex = 41;
            label6.Tag = "";
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 613);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(Balancelbl);
            Controls.Add(AccNumberlbl);
            Controls.Add(label3);
            Controls.Add(label13);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Balance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balance";
            Load += Balance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label13;
        private Label label3;
        private Label Balancelbl;
        private Label AccNumberlbl;
        private Panel panel2;
        private Label label6;
    }
}