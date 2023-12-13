namespace PRIII.WinForm.Predmeti
{
    partial class frmPredmeti
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
            dgvPredmeti = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Semestar = new DataGridViewTextBoxColumn();
            txtNaziv = new TextBox();
            cmbSemestar = new ComboBox();
            btnSacuvaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPredmeti).BeginInit();
            SuspendLayout();
            // 
            // dgvPredmeti
            // 
            dgvPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPredmeti.Columns.AddRange(new DataGridViewColumn[] { Naziv, Semestar });
            dgvPredmeti.Location = new Point(12, 81);
            dgvPredmeti.Name = "dgvPredmeti";
            dgvPredmeti.RowTemplate.Height = 25;
            dgvPredmeti.Size = new Size(503, 281);
            dgvPredmeti.TabIndex = 0;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.Name = "Naziv";
            // 
            // Semestar
            // 
            Semestar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Semestar.DataPropertyName = "Semestar";
            Semestar.HeaderText = "Semestar";
            Semestar.Name = "Semestar";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(12, 52);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(265, 23);
            txtNaziv.TabIndex = 1;
            // 
            // cmbSemestar
            // 
            cmbSemestar.FormattingEnabled = true;
            cmbSemestar.Location = new Point(283, 52);
            cmbSemestar.Name = "cmbSemestar";
            cmbSemestar.Size = new Size(151, 23);
            cmbSemestar.TabIndex = 2;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(440, 52);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Dodaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // frmPredmeti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 369);
            Controls.Add(btnSacuvaj);
            Controls.Add(cmbSemestar);
            Controls.Add(txtNaziv);
            Controls.Add(dgvPredmeti);
            Name = "frmPredmeti";
            Text = "Predmeti";
            Load += Predmeti_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPredmeti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPredmeti;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Semestar;
        private TextBox txtNaziv;
        private ComboBox cmbSemestar;
        private Button btnSacuvaj;
    }
}