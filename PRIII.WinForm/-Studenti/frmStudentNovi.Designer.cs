namespace PRIII.WinForm.Studenti
{
    partial class frmStudentNovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentNovi));
            btnSpasi = new Button();
            groupBox2 = new GroupBox();
            btnNovaLozinka = new Button();
            label7 = new Label();
            label6 = new Label();
            dtpDatumRodjenja = new DateTimePicker();
            cmbSemestar = new ComboBox();
            cbAktivan = new CheckBox();
            txtEmail = new TextBox();
            txtLozinka = new TextBox();
            label5 = new Label();
            label2 = new Label();
            txtIndeks = new TextBox();
            txtPrezime = new TextBox();
            label1 = new Label();
            txtIme = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lblFitNaslov = new Label();
            pbSlika = new PictureBox();
            ofdOdabirSlike = new OpenFileDialog();
            btnOdabirSlike = new Button();
            errNoviStudent = new ErrorProvider(components);
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errNoviStudent).BeginInit();
            SuspendLayout();
            // 
            // btnSpasi
            // 
            btnSpasi.Location = new Point(384, 205);
            btnSpasi.Margin = new Padding(3, 2, 3, 2);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(82, 22);
            btnSpasi.TabIndex = 7;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = true;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnNovaLozinka);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dtpDatumRodjenja);
            groupBox2.Controls.Add(btnSpasi);
            groupBox2.Controls.Add(cmbSemestar);
            groupBox2.Controls.Add(cbAktivan);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(txtLozinka);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtIndeks);
            groupBox2.Controls.Add(txtPrezime);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtIme);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(209, 84);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(482, 246);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnNovaLozinka
            // 
            btnNovaLozinka.BackgroundImage = (Image)resources.GetObject("btnNovaLozinka.BackgroundImage");
            btnNovaLozinka.BackgroundImageLayout = ImageLayout.Stretch;
            btnNovaLozinka.Location = new Point(441, 121);
            btnNovaLozinka.Name = "btnNovaLozinka";
            btnNovaLozinka.Size = new Size(25, 23);
            btnNovaLozinka.TabIndex = 26;
            btnNovaLozinka.UseVisualStyleBackColor = true;
            btnNovaLozinka.Click += btnNovaLozinka_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(256, 129);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 25;
            label7.Text = "Semestar:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(18, 187);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 24;
            label6.Text = "Datum Rodjenja:";
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location = new Point(18, 205);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new Size(209, 23);
            dtpDatumRodjenja.TabIndex = 3;
            // 
            // cmbSemestar
            // 
            cmbSemestar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemestar.FormattingEnabled = true;
            cmbSemestar.Location = new Point(256, 146);
            cmbSemestar.Name = "cmbSemestar";
            cmbSemestar.Size = new Size(121, 23);
            cmbSemestar.TabIndex = 6;
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Location = new Point(256, 174);
            cbAktivan.Margin = new Padding(3, 2, 3, 2);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(66, 19);
            cbAktivan.TabIndex = 0;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(18, 150);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 25);
            txtEmail.TabIndex = 2;
            // 
            // txtLozinka
            // 
            txtLozinka.Font = new Font("Segoe UI", 10F);
            txtLozinka.Location = new Point(255, 94);
            txtLozinka.Margin = new Padding(3, 2, 3, 2);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.PasswordChar = '*';
            txtLozinka.Size = new Size(211, 25);
            txtLozinka.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(16, 129);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 13;
            label5.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(256, 76);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 11;
            label2.Text = "Lozinka:";
            // 
            // txtIndeks
            // 
            txtIndeks.Font = new Font("Segoe UI", 10F);
            txtIndeks.Location = new Point(255, 45);
            txtIndeks.Margin = new Padding(3, 2, 3, 2);
            txtIndeks.Name = "txtIndeks";
            txtIndeks.Size = new Size(213, 25);
            txtIndeks.TabIndex = 4;
            // 
            // txtPrezime
            // 
            txtPrezime.Font = new Font("Segoe UI", 10F);
            txtPrezime.Location = new Point(16, 94);
            txtPrezime.Margin = new Padding(3, 2, 3, 2);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(211, 25);
            txtPrezime.TabIndex = 1;
            txtPrezime.TextChanged += txtPrezime_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(256, 23);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 10;
            label1.Text = "Broj Indeksa";
            // 
            // txtIme
            // 
            txtIme.Font = new Font("Segoe UI", 10F);
            txtIme.Location = new Point(16, 41);
            txtIme.Margin = new Padding(3, 2, 3, 2);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(213, 25);
            txtIme.TabIndex = 0;
            txtIme.TextChanged += txtIme_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(16, 23);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 10;
            label3.Text = "Ime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(16, 76);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 11;
            label4.Text = "Prezime";
            // 
            // lblFitNaslov
            // 
            lblFitNaslov.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFitNaslov.Location = new Point(143, 9);
            lblFitNaslov.Name = "lblFitNaslov";
            lblFitNaslov.Size = new Size(398, 58);
            lblFitNaslov.TabIndex = 19;
            lblFitNaslov.Text = "Univerzitet \"Džemal Bijedić\" Fakultet informacijskih tehnologija www.fit.ba";
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(12, 94);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(182, 201);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 21;
            pbSlika.TabStop = false;
            // 
            // ofdOdabirSlike
            // 
            ofdOdabirSlike.FileName = "openFileDialog1";
            ofdOdabirSlike.Filter = "*.jpg | *.png";
            // 
            // btnOdabirSlike
            // 
            btnOdabirSlike.Location = new Point(12, 306);
            btnOdabirSlike.Name = "btnOdabirSlike";
            btnOdabirSlike.Size = new Size(182, 23);
            btnOdabirSlike.TabIndex = 0;
            btnOdabirSlike.Text = "Odabir Slike";
            btnOdabirSlike.UseVisualStyleBackColor = true;
            btnOdabirSlike.Click += btnOdabirSlike_Click;
            // 
            // errNoviStudent
            // 
            errNoviStudent.ContainerControl = this;
            // 
            // frmStudentNovi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 341);
            Controls.Add(btnOdabirSlike);
            Controls.Add(pbSlika);
            Controls.Add(groupBox2);
            Controls.Add(lblFitNaslov);
            Name = "frmStudentNovi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Novi";
            Load += frmStudentNovi_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errNoviStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSpasi;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private DateTimePicker dtpDatumRodjenja;
        private ComboBox cmbSemestar;
        private CheckBox cbAktivan;
        private TextBox txtEmail;
        private TextBox txtLozinka;
        private Label label5;
        private Label label2;
        private TextBox txtIndeks;
        private TextBox txtPrezime;
        private Label label1;
        private TextBox txtIme;
        private Label label3;
        private Label label4;
        private Label lblFitNaslov;
        private PictureBox pbSlika;
        private OpenFileDialog ofdOdabirSlike;
        private Button btnOdabirSlike;
        private Button btnNovaLozinka;
        private ErrorProvider errNoviStudent;
    }
}