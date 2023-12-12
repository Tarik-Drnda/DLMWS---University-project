namespace PRIII.WinForm._Studenti
{
    partial class frmStudentiPredmeti
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
            components = new System.ComponentModel.Container();
            dgvPolozeniPredmeti = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            DatumPolaganja = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            lblPredmet = new Label();
            cmbPredmeti = new ComboBox();
            cmbOcjene = new ComboBox();
            lblOcjena = new Label();
            lblDatumPolaganja = new Label();
            btnDodaj = new Button();
            dtmPolaganje = new DateTimePicker();
            errPolozeniPredmet = new ErrorProvider(components);
            lblImePrezime = new Label();
            pcbProfilna = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPolozeniPredmeti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errPolozeniPredmet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbProfilna).BeginInit();
            SuspendLayout();
            // 
            // dgvPolozeniPredmeti
            // 
            dgvPolozeniPredmeti.AllowUserToAddRows = false;
            dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPolozeniPredmeti.Columns.AddRange(new DataGridViewColumn[] { Predmet, DatumPolaganja, Ocjena });
            dgvPolozeniPredmeti.Location = new Point(8, 198);
            dgvPolozeniPredmeti.Name = "dgvPolozeniPredmeti";
            dgvPolozeniPredmeti.RowTemplate.Height = 25;
            dgvPolozeniPredmeti.Size = new Size(424, 263);
            dgvPolozeniPredmeti.TabIndex = 0;
            dgvPolozeniPredmeti.CellContentClick += dgvPolozeniPredmeti_CellContentClick;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            // 
            // DatumPolaganja
            // 
            DatumPolaganja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPolaganja.DataPropertyName = "DatumPolaganja";
            DatumPolaganja.HeaderText = "Datum polaganja";
            DatumPolaganja.Name = "DatumPolaganja";
            // 
            // Ocjena
            // 
            Ocjena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ocjena.DataPropertyName = "Ocjena";
            Ocjena.HeaderText = "Ocjena";
            Ocjena.Name = "Ocjena";
            // 
            // lblPredmet
            // 
            lblPredmet.AutoSize = true;
            lblPredmet.Location = new Point(12, 151);
            lblPredmet.Name = "lblPredmet";
            lblPredmet.Size = new Size(55, 15);
            lblPredmet.TabIndex = 1;
            lblPredmet.Text = "Predmet:";
            // 
            // cmbPredmeti
            // 
            cmbPredmeti.FormattingEnabled = true;
            cmbPredmeti.Location = new Point(8, 171);
            cmbPredmeti.Name = "cmbPredmeti";
            cmbPredmeti.Size = new Size(121, 23);
            cmbPredmeti.TabIndex = 2;
            // 
            // cmbOcjene
            // 
            cmbOcjene.FormattingEnabled = true;
            cmbOcjene.Location = new Point(135, 171);
            cmbOcjene.Name = "cmbOcjene";
            cmbOcjene.Size = new Size(88, 23);
            cmbOcjene.TabIndex = 4;
            // 
            // lblOcjena
            // 
            lblOcjena.AutoSize = true;
            lblOcjena.Location = new Point(135, 153);
            lblOcjena.Name = "lblOcjena";
            lblOcjena.Size = new Size(47, 15);
            lblOcjena.TabIndex = 3;
            lblOcjena.Text = "Ocjena:";
            // 
            // lblDatumPolaganja
            // 
            lblDatumPolaganja.AutoSize = true;
            lblDatumPolaganja.Location = new Point(230, 153);
            lblDatumPolaganja.Name = "lblDatumPolaganja";
            lblDatumPolaganja.Size = new Size(104, 15);
            lblDatumPolaganja.TabIndex = 6;
            lblDatumPolaganja.Text = "Datum Polaganja: ";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(357, 170);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dtmPolaganje
            // 
            dtmPolaganje.Location = new Point(228, 171);
            dtmPolaganje.Name = "dtmPolaganje";
            dtmPolaganje.Size = new Size(123, 23);
            dtmPolaganje.TabIndex = 8;
            // 
            // errPolozeniPredmet
            // 
            errPolozeniPredmet.ContainerControl = this;
            // 
            // lblImePrezime
            // 
            lblImePrezime.AutoSize = true;
            lblImePrezime.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImePrezime.Location = new Point(135, 61);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(0, 30);
            lblImePrezime.TabIndex = 9;
            // 
            // pcbProfilna
            // 
            pcbProfilna.Location = new Point(8, 12);
            pcbProfilna.Name = "pcbProfilna";
            pcbProfilna.Size = new Size(121, 136);
            pcbProfilna.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbProfilna.TabIndex = 10;
            pcbProfilna.TabStop = false;
            // 
            // frmStudentiPredmeti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 473);
            Controls.Add(pcbProfilna);
            Controls.Add(lblImePrezime);
            Controls.Add(dtmPolaganje);
            Controls.Add(btnDodaj);
            Controls.Add(lblDatumPolaganja);
            Controls.Add(cmbOcjene);
            Controls.Add(lblOcjena);
            Controls.Add(cmbPredmeti);
            Controls.Add(lblPredmet);
            Controls.Add(dgvPolozeniPredmeti);
            Name = "frmStudentiPredmeti";
            Text = "Uspijeh Student";
            Load += frmStudentiPredmeti_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPolozeniPredmeti).EndInit();
            ((System.ComponentModel.ISupportInitialize)errPolozeniPredmet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbProfilna).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPolozeniPredmeti;
        private Label lblPredmet;
        private ComboBox cmbPredmeti;
        private ComboBox cmbOcjene;
        private Label lblOcjena;
        private Label lblDatumPolaganja;
        private Button btnDodaj;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn DatumPolaganja;
        private DataGridViewTextBoxColumn Ocjena;
        private DateTimePicker dtmPolaganje;
        private ErrorProvider errPolozeniPredmet;
        private Label lblImePrezime;
        private PictureBox pcbProfilna;
    }
}