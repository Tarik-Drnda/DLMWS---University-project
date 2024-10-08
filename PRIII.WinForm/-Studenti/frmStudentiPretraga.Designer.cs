﻿namespace PRIII.WinForm.Studenti
{
    partial class frmStudentiPretraga
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
            btnStudentNovi = new Button();
            txtFilter = new TextBox();
            Indeks = new DataGridViewTextBoxColumn();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Semestar = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            PolozeniPredmeti = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Indeks, Ime, Prezime, DatumRodjenja, Semestar, Aktivan, PolozeniPredmeti });
            dgvStudenti.Location = new Point(10, 50);
            dgvStudenti.Margin = new Padding(3, 2, 3, 2);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.RowTemplate.Height = 25;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(649, 238);
            dgvStudenti.TabIndex = 0;
            dgvStudenti.CellContentClick += dgvStudenti_CellContentClick;
            // 
            // btnStudentNovi
            // 
            btnStudentNovi.Location = new Point(547, 292);
            btnStudentNovi.Margin = new Padding(3, 2, 3, 2);
            btnStudentNovi.Name = "btnStudentNovi";
            btnStudentNovi.Size = new Size(112, 23);
            btnStudentNovi.TabIndex = 1;
            btnStudentNovi.Text = "Novi Student";
            btnStudentNovi.UseVisualStyleBackColor = true;
            btnStudentNovi.Click += btnStudentNovi_Click;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(10, 11);
            txtFilter.Margin = new Padding(3, 2, 3, 2);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(649, 23);
            txtFilter.TabIndex = 2;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // Indeks
            // 
            Indeks.DataPropertyName = "Indeks";
            Indeks.HeaderText = "Indeks";
            Indeks.MinimumWidth = 6;
            Indeks.Name = "Indeks";
            Indeks.ReadOnly = true;
            Indeks.Width = 125;
            // 
            // Ime
            // 
            Ime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ime.DataPropertyName = "Ime";
            Ime.HeaderText = "Ime";
            Ime.MinimumWidth = 6;
            Ime.Name = "Ime";
            Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            Prezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prezime.DataPropertyName = "Prezime";
            Prezime.HeaderText = "Prezime";
            Prezime.MinimumWidth = 6;
            Prezime.Name = "Prezime";
            Prezime.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "DatumRodjenja";
            DatumRodjenja.MinimumWidth = 6;
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            // 
            // Semestar
            // 
            Semestar.DataPropertyName = "Semestar";
            Semestar.HeaderText = "Semestar";
            Semestar.MinimumWidth = 6;
            Semestar.Name = "Semestar";
            Semestar.ReadOnly = true;
            Semestar.Width = 125;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Resizable = DataGridViewTriState.True;
            Aktivan.SortMode = DataGridViewColumnSortMode.Automatic;
            Aktivan.Width = 125;
            // 
            // PolozeniPredmeti
            // 
            PolozeniPredmeti.DataPropertyName = "PolozeniPredmeti";
            PolozeniPredmeti.HeaderText = "Predmeti";
            PolozeniPredmeti.Name = "PolozeniPredmeti";
            PolozeniPredmeti.ReadOnly = true;
            PolozeniPredmeti.Resizable = DataGridViewTriState.True;
            PolozeniPredmeti.SortMode = DataGridViewColumnSortMode.Automatic;
            PolozeniPredmeti.Text = "Predmeti";
            PolozeniPredmeti.UseColumnTextForButtonValue = true;
            // 
            // frmStudentiPretraga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 326);
            Controls.Add(txtFilter);
            Controls.Add(btnStudentNovi);
            Controls.Add(dgvStudenti);
            Name = "frmStudentiPretraga";
            Text = "Studenti Pretraga";
            Load += frmStudentiPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudenti;
        private Button btnStudentNovi;
        private TextBox txtFilter;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewTextBoxColumn Semestar;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn PolozeniPredmeti;
    }
}