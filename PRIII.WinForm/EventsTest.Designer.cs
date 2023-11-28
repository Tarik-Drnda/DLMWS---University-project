namespace PRIII.WinForm
{
    partial class EventsTest
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
            cbHTE = new CheckBox();
            cbBHT = new CheckBox();
            rtbPoruka = new TextBox();
            btn_test = new Button();
            cbHaloo = new CheckBox();
            SuspendLayout();
            // 
            // cbHTE
            // 
            cbHTE.AutoSize = true;
            cbHTE.Location = new Point(121, 209);
            cbHTE.Name = "cbHTE";
            cbHTE.Size = new Size(74, 19);
            cbHTE.TabIndex = 7;
            cbHTE.Text = "HTeronet";
            cbHTE.UseVisualStyleBackColor = true;
            cbHTE.CheckedChanged += cbHTE_CheckedChanged;
            // 
            // cbBHT
            // 
            cbBHT.AutoSize = true;
            cbBHT.Location = new Point(16, 209);
            cbBHT.Name = "cbBHT";
            cbBHT.Size = new Size(86, 19);
            cbBHT.TabIndex = 6;
            cbBHT.Text = "BHTelecom";
            cbBHT.UseVisualStyleBackColor = true;
            cbBHT.CheckedChanged += cbBHT_CheckedChanged;
            // 
            // rtbPoruka
            // 
            rtbPoruka.Location = new Point(12, 12);
            rtbPoruka.Multiline = true;
            rtbPoruka.Name = "rtbPoruka";
            rtbPoruka.Size = new Size(455, 184);
            rtbPoruka.TabIndex = 5;
            // 
            // btn_test
            // 
            btn_test.Location = new Point(385, 206);
            btn_test.Margin = new Padding(3, 2, 3, 2);
            btn_test.Name = "btn_test";
            btn_test.Size = new Size(82, 22);
            btn_test.TabIndex = 4;
            btn_test.Text = "SEND";
            btn_test.UseVisualStyleBackColor = true;
            btn_test.Click += btn_test_Click;
            // 
            // cbHaloo
            // 
            cbHaloo.AutoSize = true;
            cbHaloo.Location = new Point(211, 209);
            cbHaloo.Name = "cbHaloo";
            cbHaloo.Size = new Size(58, 19);
            cbHaloo.TabIndex = 8;
            cbHaloo.Text = "Haloo";
            cbHaloo.UseVisualStyleBackColor = true;
            cbHaloo.CheckedChanged += cbHaloo_CheckedChanged;
            // 
            // EventsTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 254);
            Controls.Add(cbHaloo);
            Controls.Add(cbHTE);
            Controls.Add(cbBHT);
            Controls.Add(rtbPoruka);
            Controls.Add(btn_test);
            Name = "EventsTest";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbHTE;
        private CheckBox cbBHT;
        private TextBox rtbPoruka;
        private Button btn_test;
        private CheckBox cbHaloo;
    }
}