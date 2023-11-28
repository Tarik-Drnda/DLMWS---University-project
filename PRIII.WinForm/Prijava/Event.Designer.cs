namespace PRIII.WinForm
{
    partial class Event
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_test = new Button();
            textBox1 = new TextBox();
            cbBHT = new CheckBox();
            cbHTE = new CheckBox();
            SuspendLayout();
            // 
            // btn_test
            // 
            btn_test.Location = new Point(385, 217);
            btn_test.Margin = new Padding(3, 2, 3, 2);
            btn_test.Name = "btn_test";
            btn_test.Size = new Size(82, 22);
            btn_test.TabIndex = 0;
            btn_test.Text = "button1";
            btn_test.UseVisualStyleBackColor = true;
            btn_test.Click += btn_test_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(455, 184);
            textBox1.TabIndex = 1;
            // 
            // cbBHT
            // 
            cbBHT.AutoSize = true;
            cbBHT.Location = new Point(16, 209);
            cbBHT.Name = "cbBHT";
            cbBHT.Size = new Size(86, 19);
            cbBHT.TabIndex = 2;
            cbBHT.Text = "BHTelecom";
            cbBHT.UseVisualStyleBackColor = true;
            cbBHT.CheckedChanged += cbBHT_CheckedChanged;
            // 
            // cbHTE
            // 
            cbHTE.AutoSize = true;
            cbHTE.Location = new Point(121, 209);
            cbHTE.Name = "cbHTE";
            cbHTE.Size = new Size(74, 19);
            cbHTE.TabIndex = 3;
            cbHTE.Text = "HTeronet";
            cbHTE.UseVisualStyleBackColor = true;
            cbHTE.CheckedChanged += cbHTE_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 252);
            Controls.Add(cbHTE);
            Controls.Add(cbBHT);
            Controls.Add(textBox1);
            Controls.Add(btn_test);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_test;
        private TextBox textBox1;
        private CheckBox cbBHT;
        private CheckBox cbHTE;
    }
}