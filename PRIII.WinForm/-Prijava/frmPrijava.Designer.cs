namespace PRIII.WinForm
{
    partial class frmPrijava
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
            txtKorisnickoIme = new TextBox();
            txtLozinka = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnPrijava = new Button();
            picProfilna = new PictureBox();
            label3 = new Label();
            err = new ErrorProvider(components);
            lblRegistracija = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)picProfilna).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtKorisnickoIme.Location = new Point(360, 85);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(243, 30);
            txtKorisnickoIme.TabIndex = 0;
            txtKorisnickoIme.Text = "admin";
            txtKorisnickoIme.TextChanged += txtKorisnickoIme_TextChanged;
            // 
            // txtLozinka
            // 
            txtLozinka.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtLozinka.Location = new Point(362, 159);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(241, 30);
            txtLozinka.TabIndex = 1;
            txtLozinka.Text = "admin";
            txtLozinka.TextChanged += txtLozinka_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(361, 57);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 2;
            label1.Text = "Korisničko ime: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(360, 127);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Lozinka:";
            label2.Click += label2_Click;
            // 
            // btnPrijava
            // 
            btnPrijava.Location = new Point(509, 210);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(94, 29);
            btnPrijava.TabIndex = 4;
            btnPrijava.Text = "Prijava";
            btnPrijava.UseVisualStyleBackColor = true;
            btnPrijava.Click += btnPrijava_Click;
            // 
            // picProfilna
            // 
            picProfilna.Image = Properties.Resources.am_a_19_year_old_multimedia_artist_student_from_manila__21;
            picProfilna.Location = new Point(143, 57);
            picProfilna.Name = "picProfilna";
            picProfilna.Size = new Size(180, 177);
            picProfilna.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfilna.TabIndex = 5;
            picProfilna.TabStop = false;
            picProfilna.Click += picProfilna_Click;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(342, 54);
            label3.Name = "label3";
            label3.Size = new Size(1, 180);
            label3.TabIndex = 6;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // lblRegistracija
            // 
            lblRegistracija.AutoSize = true;
            lblRegistracija.Location = new Point(360, 214);
            lblRegistracija.Name = "lblRegistracija";
            lblRegistracija.Size = new Size(129, 20);
            lblRegistracija.TabIndex = 7;
            lblRegistracija.TabStop = true;
            lblRegistracija.Text = "niste registrovani?";
            lblRegistracija.LinkClicked += lblRegistracija_LinkClicked;
            // 
            // frmPrijava
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 307);
            Controls.Add(lblRegistracija);
            Controls.Add(label3);
            Controls.Add(picProfilna);
            Controls.Add(btnPrijava);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLozinka);
            Controls.Add(txtKorisnickoIme);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrijava";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DLMWS :: Prijava";
            ((System.ComponentModel.ISupportInitialize)picProfilna).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKorisnickoIme;
        private TextBox txtLozinka;
        private Label label1;
        private Label label2;
        private Button btnPrijava;
        private PictureBox picProfilna;
        private Label label3;
        private ErrorProvider err;
        private LinkLabel lblRegistracija;
    }
}