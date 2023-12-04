namespace PRIII.WinForm
{
    partial class frmRegistracija
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
            picProfilna = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            txtLozinka = new TextBox();
            txtKorisnickoIme = new TextBox();
            lblFitNaslov = new Label();
            groupBox1 = new GroupBox();
            cbAktivan = new CheckBox();
            groupBox2 = new GroupBox();
            txtEmail = new TextBox();
            label5 = new Label();
            txtPrezime = new TextBox();
            txtIme = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnSpasi = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)picProfilna).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // picProfilna
            // 
            picProfilna.Image = Properties.Resources.am_a_19_year_old_multimedia_artist_student_from_manila__21;
            picProfilna.Location = new Point(12, 12);
            picProfilna.Name = "picProfilna";
            picProfilna.Size = new Size(125, 122);
            picProfilna.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfilna.TabIndex = 13;
            picProfilna.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 123);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 11;
            label2.Text = "Lozinka:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 53);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 10;
            label1.Text = "Korisničko ime: ";
            // 
            // txtLozinka
            // 
            txtLozinka.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtLozinka.Location = new Point(20, 155);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(241, 30);
            txtLozinka.TabIndex = 4;
            txtLozinka.Text = "admin";
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtKorisnickoIme.Location = new Point(18, 81);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(243, 30);
            txtKorisnickoIme.TabIndex = 3;
            txtKorisnickoIme.Text = "admin";
            // 
            // lblFitNaslov
            // 
            lblFitNaslov.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblFitNaslov.Location = new Point(226, 12);
            lblFitNaslov.Name = "lblFitNaslov";
            lblFitNaslov.Size = new Size(455, 77);
            lblFitNaslov.TabIndex = 14;
            lblFitNaslov.Text = "Univerzitet \"Džemal Bijedić\" Fakultet informacijskih tehnologija www.fit.ba";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbAktivan);
            groupBox1.Controls.Add(txtLozinka);
            groupBox1.Controls.Add(txtKorisnickoIme);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(437, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 231);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Korisnički podaci";
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Location = new Point(23, 200);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(80, 24);
            cbAktivan.TabIndex = 0;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtPrezime);
            groupBox2.Controls.Add(txtIme);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(48, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(313, 283);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lični podaci";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(20, 200);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(241, 30);
            txtEmail.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 174);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 13;
            label5.Text = "Email";
            // 
            // txtPrezime
            // 
            txtPrezime.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrezime.Location = new Point(18, 126);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(241, 30);
            txtPrezime.TabIndex = 1;
            txtPrezime.TextChanged += txtPrezime_TextChanged;
            // 
            // txtIme
            // 
            txtIme.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtIme.Location = new Point(18, 55);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(243, 30);
            txtIme.TabIndex = 0;
            txtIme.TextChanged += txtIme_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 32);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 10;
            label3.Text = "Ime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 103);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 11;
            label4.Text = "Prezime";
            // 
            // btnSpasi
            // 
            btnSpasi.Location = new Point(656, 392);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(94, 29);
            btnSpasi.TabIndex = 2;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = true;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmRegistracija
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSpasi);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblFitNaslov);
            Controls.Add(picProfilna);
            Name = "frmRegistracija";
            Text = "frmRegistracija";
            ((System.ComponentModel.ISupportInitialize)picProfilna).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picProfilna;
        private Label label2;
        private Label label1;
        private TextBox txtLozinka;
        private TextBox txtKorisnickoIme;
        private Label lblFitNaslov;
        private GroupBox groupBox1;
        private CheckBox cbAktivan;
        private GroupBox groupBox2;
        private TextBox txtPrezime;
        private TextBox txtIme;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private Button btnSpasi;
        private ErrorProvider errorProvider1;
    }
}