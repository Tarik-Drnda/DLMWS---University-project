namespace PRIII.WinForm._Prijava
{
    partial class frmPingTest
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
            txtLog = new TextBox();
            PING = new Button();
            SuspendLayout();
            // 
            // txtLog
            // 
            txtLog.Font = new Font("Segoe UI", 12F);
            txtLog.Location = new Point(12, 40);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(458, 398);
            txtLog.TabIndex = 0;
            // 
            // PING
            // 
            PING.Location = new Point(395, 12);
            PING.Name = "PING";
            PING.Size = new Size(75, 23);
            PING.TabIndex = 1;
            PING.Text = "Ping";
            PING.UseVisualStyleBackColor = true;
            PING.Click += PING_Click;
            // 
            // frmPingTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 450);
            Controls.Add(PING);
            Controls.Add(txtLog);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmPingTest";
            Text = "frmPingTest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLog;
        private Button PING;
    }
}