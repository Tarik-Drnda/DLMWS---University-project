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
            dgvPredmeti.Location = new Point(14, 66);
            dgvPredmeti.Margin = new Padding(3, 4, 3, 4);
            dgvPredmeti.Name = "dgvPredmeti";
            dgvPredmeti.RowHeadersWidth = 51;
            dgvPredmeti.RowTemplate.Height = 25;
            dgvPredmeti.Size = new Size(575, 304);
            dgvPredmeti.TabIndex = 0;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            // 
            // Semestar
            // 
            Semestar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Semestar.DataPropertyName = "Semestar";
            Semestar.HeaderText = "Semestar";
            Semestar.MinimumWidth = 6;
            Semestar.Name = "Semestar";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(14, 27);
            txtNaziv.Margin = new Padding(3, 4, 3, 4);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(302, 27);
            txtNaziv.TabIndex = 1;
            // 
            // cmbSemestar
            // 
            cmbSemestar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemestar.FormattingEnabled = true;
            cmbSemestar.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            cmbSemestar.Location = new Point(322, 27);
            cmbSemestar.Margin = new Padding(3, 4, 3, 4);
            cmbSemestar.Name = "cmbSemestar";
            cmbSemestar.Size = new Size(172, 28);
            cmbSemestar.TabIndex = 2;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(500, 27);
            btnSacuvaj.Margin = new Padding(3, 4, 3, 4);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(86, 31);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Dodaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // frmPredmeti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 375);
            Controls.Add(btnSacuvaj);
            Controls.Add(cmbSemestar);
            Controls.Add(txtNaziv);
            Controls.Add(dgvPredmeti);
            Margin = new Padding(3, 4, 3, 4);
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