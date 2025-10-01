namespace ATMTuto
{
    partial class ChangePin
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
            label3 = new Label();
            label13 = new Label();
            LOCIN = new Button();
            Pin2Tb = new TextBox();
            Pin1Tb = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
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
            label1.Location = new Point(214, 58);
            label1.Name = "label1";
            label1.Size = new Size(481, 43);
            label1.TabIndex = 2;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Monospac821 BT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(226, 339);
            label3.Name = "label3";
            label3.Size = new Size(219, 34);
            label3.TabIndex = 41;
            label3.Text = "CONFIRM PIN:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.Font = new Font("Monospac821 BT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(226, 240);
            label13.Name = "label13";
            label13.Size = new Size(151, 34);
            label13.TabIndex = 40;
            label13.Text = "NEW PIN:";
            // 
            // LOCIN
            // 
            LOCIN.BackColor = Color.DarkSlateGray;
            LOCIN.ForeColor = Color.White;
            LOCIN.Location = new Point(475, 419);
            LOCIN.Name = "LOCIN";
            LOCIN.Size = new Size(242, 50);
            LOCIN.TabIndex = 44;
            LOCIN.Text = "Change";
            LOCIN.UseVisualStyleBackColor = false;
            LOCIN.Click += LOCIN_Click;
            // 
            // Pin2Tb
            // 
            Pin2Tb.Font = new Font("Monospac821 BT", 14F, FontStyle.Bold);
            Pin2Tb.Location = new Point(475, 332);
            Pin2Tb.Name = "Pin2Tb";
            Pin2Tb.Size = new Size(242, 41);
            Pin2Tb.TabIndex = 43;
            Pin2Tb.TextChanged += textBox2_TextChanged;
            // 
            // Pin1Tb
            // 
            Pin1Tb.Font = new Font("Monospac821 BT", 14F, FontStyle.Bold);
            Pin1Tb.Location = new Point(475, 240);
            Pin1Tb.Name = "Pin1Tb";
            Pin1Tb.Size = new Size(242, 41);
            Pin1Tb.TabIndex = 42;
            Pin1Tb.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Monospac821 BT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(546, 483);
            label6.Name = "label6";
            label6.Size = new Size(83, 34);
            label6.TabIndex = 45;
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
            panel2.TabIndex = 46;
            // 
            // ChangePin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 613);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(LOCIN);
            Controls.Add(Pin2Tb);
            Controls.Add(Pin1Tb);
            Controls.Add(label3);
            Controls.Add(label13);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChangePin";
            Load += ChangePin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label13;
        private Button LOCIN;
        private TextBox Pin2Tb;
        private TextBox Pin1Tb;
        private Label label6;
        private Panel panel2;
    }
}