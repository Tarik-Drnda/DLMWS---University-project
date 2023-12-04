namespace PRIII.WinForm._P8
{
    partial class P8
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
            dgvStudenti = new DataGridView();
            txtFilter = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // dgvStudenti
            // 
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Location = new Point(12, 41);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.RowTemplate.Height = 25;
            dgvStudenti.Size = new Size(776, 397);
            dgvStudenti.TabIndex = 0;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(12, 12);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(776, 23);
            txtFilter.TabIndex = 1;
            // 
            // P8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFilter);
            Controls.Add(dgvStudenti);
            Name = "P8";
            Text = "P8";
            Load += P8_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudenti;
        private TextBox txtFilter;
    }
}