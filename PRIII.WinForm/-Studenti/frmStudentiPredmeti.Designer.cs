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
            dgvPolozeniPredmeti = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            DatumPolaganja = new DataGridViewTextBoxColumn();
            lblPredmet = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            lblOcjena = new Label();
            comboBox3 = new ComboBox();
            lblDatumPolaganja = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPolozeniPredmeti).BeginInit();
            SuspendLayout();
            // 
            // dgvPolozeniPredmeti
            // 
            dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPolozeniPredmeti.Columns.AddRange(new DataGridViewColumn[] { Predmet, Ocjena, DatumPolaganja });
            dgvPolozeniPredmeti.Location = new Point(12, 78);
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
            // Ocjena
            // 
            Ocjena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ocjena.DataPropertyName = "Ocjena";
            Ocjena.HeaderText = "Ocjena";
            Ocjena.Name = "Ocjena";
            // 
            // DatumPolaganja
            // 
            DatumPolaganja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPolaganja.DataPropertyName = "DatumPolaganja";
            DatumPolaganja.HeaderText = "Datum polaganja";
            DatumPolaganja.Name = "DatumPolaganja";
            // 
            // lblPredmet
            // 
            lblPredmet.AutoSize = true;
            lblPredmet.Location = new Point(12, 33);
            lblPredmet.Name = "lblPredmet";
            lblPredmet.Size = new Size(55, 15);
            lblPredmet.TabIndex = 1;
            lblPredmet.Text = "Predmet:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(139, 51);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(88, 23);
            comboBox2.TabIndex = 4;
            // 
            // lblOcjena
            // 
            lblOcjena.AutoSize = true;
            lblOcjena.Location = new Point(139, 33);
            lblOcjena.Name = "lblOcjena";
            lblOcjena.Size = new Size(47, 15);
            lblOcjena.TabIndex = 3;
            lblOcjena.Text = "Ocjena:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(234, 51);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 5;
            // 
            // lblDatumPolaganja
            // 
            lblDatumPolaganja.AutoSize = true;
            lblDatumPolaganja.Location = new Point(234, 33);
            lblDatumPolaganja.Name = "lblDatumPolaganja";
            lblDatumPolaganja.Size = new Size(104, 15);
            lblDatumPolaganja.TabIndex = 6;
            lblDatumPolaganja.Text = "Datum Polaganja: ";
            // 
            // button1
            // 
            button1.Location = new Point(361, 51);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmStudentiPredmeti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 351);
            Controls.Add(button1);
            Controls.Add(lblDatumPolaganja);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(lblOcjena);
            Controls.Add(comboBox1);
            Controls.Add(lblPredmet);
            Controls.Add(dgvPolozeniPredmeti);
            Name = "frmStudentiPredmeti";
            Text = "Uspijeh Student";
            Load += frmStudentiPredmeti_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPolozeniPredmeti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPolozeniPredmeti;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn DatumPolaganja;
        private Label lblPredmet;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label lblOcjena;
        private ComboBox comboBox3;
        private Label lblDatumPolaganja;
        private Button button1;
    }
}