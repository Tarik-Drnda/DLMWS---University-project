﻿namespace PRIII.WinForm.Asinhrono
{
    partial class frmPing
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
            txtIspis = new TextBox();
            btnPing = new Button();
            SuspendLayout();
            // 
            // txtIspis
            // 
            txtIspis.Font = new Font("Segoe UI", 12F);
            txtIspis.Location = new Point(12, 55);
            txtIspis.Multiline = true;
            txtIspis.Name = "txtIspis";
            txtIspis.ScrollBars = ScrollBars.Vertical;
            txtIspis.Size = new Size(504, 314);
            txtIspis.TabIndex = 0;
            // 
            // btnPing
            // 
            btnPing.Location = new Point(441, 26);
            btnPing.Name = "btnPing";
            btnPing.Size = new Size(75, 23);
            btnPing.TabIndex = 1;
            btnPing.Text = "PING";
            btnPing.UseVisualStyleBackColor = true;
            btnPing.Click += btnPing_Click;
            // 
            // frmPing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 381);
            Controls.Add(btnPing);
            Controls.Add(txtIspis);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmPing";
            Text = "frmPing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIspis;
        private Button btnPing;
    }
}