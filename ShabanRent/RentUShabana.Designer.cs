namespace ShabanRent
{
    partial class RentUShabana
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
            this.components = new System.ComponentModel.Container();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numBrojDana = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.lblDani = new System.Windows.Forms.Label();
            this.checkDani = new System.Windows.Forms.CheckBox();
            this.checkMijesec = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnUcitajSliku = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblKM = new System.Windows.Forms.Label();
            this.lblKM2 = new System.Windows.Forms.Label();
            this.lblMijesec = new System.Windows.Forms.Label();
            this.ofdUcitajSlku = new System.Windows.Forms.OpenFileDialog();
            this.cmbGradovi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodajGrad = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBoxSlika = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBrojIndeksa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojDana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(313, 164);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(282, 27);
            this.txtIme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // numBrojDana
            // 
            this.numBrojDana.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBrojDana.Location = new System.Drawing.Point(628, 93);
            this.numBrojDana.Name = "numBrojDana";
            this.numBrojDana.Size = new System.Drawing.Size(132, 27);
            this.numBrojDana.TabIndex = 3;
            this.numBrojDana.Visible = false;
            this.numBrojDana.ValueChanged += new System.EventHandler(this.NumBrojDana_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.Location = new System.Drawing.Point(313, 267);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(282, 27);
            this.txtPrezime.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(624, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kod za sobu";
            // 
            // txtKod
            // 
            this.txtKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKod.Location = new System.Drawing.Point(628, 196);
            this.txtKod.Name = "txtKod";
            this.txtKod.PasswordChar = '*';
            this.txtKod.ReadOnly = true;
            this.txtKod.Size = new System.Drawing.Size(244, 27);
            this.txtKod.TabIndex = 6;
            // 
            // lblDani
            // 
            this.lblDani.AutoSize = true;
            this.lblDani.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDani.Location = new System.Drawing.Point(624, 46);
            this.lblDani.Name = "lblDani";
            this.lblDani.Size = new System.Drawing.Size(182, 22);
            this.lblDani.TabIndex = 8;
            this.lblDani.Text = "Koliko dana ostajete?";
            this.lblDani.Visible = false;
            // 
            // checkDani
            // 
            this.checkDani.AutoSize = true;
            this.checkDani.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDani.Location = new System.Drawing.Point(313, 404);
            this.checkDani.Name = "checkDani";
            this.checkDani.Size = new System.Drawing.Size(66, 26);
            this.checkDani.TabIndex = 9;
            this.checkDani.Text = "Dani";
            this.checkDani.UseVisualStyleBackColor = true;
            this.checkDani.CheckedChanged += new System.EventHandler(this.CheckDani_CheckedChanged);
            // 
            // checkMijesec
            // 
            this.checkMijesec.AutoSize = true;
            this.checkMijesec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMijesec.Location = new System.Drawing.Point(468, 404);
            this.checkMijesec.Name = "checkMijesec";
            this.checkMijesec.Size = new System.Drawing.Size(89, 26);
            this.checkMijesec.TabIndex = 10;
            this.checkMijesec.Text = "Mijesec";
            this.checkMijesec.UseVisualStyleBackColor = true;
            this.checkMijesec.CheckedChanged += new System.EventHandler(this.CheckMijesec_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Odaberite opciju noćenja";
            // 
            // btnPrijava
            // 
            this.btnPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.Location = new System.Drawing.Point(628, 346);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(282, 56);
            this.btnPrijava.TabIndex = 12;
            this.btnPrijava.Text = "Prijavi se!";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.BtnPrijava_Click);
            // 
            // btnUcitajSliku
            // 
            this.btnUcitajSliku.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitajSliku.Location = new System.Drawing.Point(12, 381);
            this.btnUcitajSliku.Name = "btnUcitajSliku";
            this.btnUcitajSliku.Size = new System.Drawing.Size(248, 56);
            this.btnUcitajSliku.TabIndex = 13;
            this.btnUcitajSliku.Text = "Učitaj Sliku";
            this.btnUcitajSliku.UseVisualStyleBackColor = true;
            this.btnUcitajSliku.Click += new System.EventHandler(this.BtnUcitajSliku_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKM.Location = new System.Drawing.Point(775, 96);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(20, 22);
            this.lblKM.TabIndex = 14;
            this.lblKM.Text = "0";
            this.lblKM.Visible = false;
            // 
            // lblKM2
            // 
            this.lblKM2.AutoSize = true;
            this.lblKM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKM2.Location = new System.Drawing.Point(826, 98);
            this.lblKM2.Name = "lblKM2";
            this.lblKM2.Size = new System.Drawing.Size(117, 22);
            this.lblKM2.TabIndex = 15;
            this.lblKM2.Text = "KM vas košta";
            this.lblKM2.Visible = false;
            // 
            // lblMijesec
            // 
            this.lblMijesec.AutoSize = true;
            this.lblMijesec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMijesec.Location = new System.Drawing.Point(624, 68);
            this.lblMijesec.Name = "lblMijesec";
            this.lblMijesec.Size = new System.Drawing.Size(238, 22);
            this.lblMijesec.TabIndex = 16;
            this.lblMijesec.Text = "180KM  vam je mijesec dana";
            this.lblMijesec.Visible = false;
            // 
            // ofdUcitajSlku
            // 
            this.ofdUcitajSlku.FileName = "Ucitaj Sliku";
            // 
            // cmbGradovi
            // 
            this.cmbGradovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGradovi.FormattingEnabled = true;
            this.cmbGradovi.Location = new System.Drawing.Point(628, 283);
            this.cmbGradovi.Name = "cmbGradovi";
            this.cmbGradovi.Size = new System.Drawing.Size(196, 28);
            this.cmbGradovi.TabIndex = 18;
            this.cmbGradovi.SelectedIndexChanged += new System.EventHandler(this.cmbGradovi_SelectedIndexChanged);
            this.cmbGradovi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbGradovi_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(624, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Grad";
            // 
            // btnDodajGrad
            // 
            this.btnDodajGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajGrad.Location = new System.Drawing.Point(830, 283);
            this.btnDodajGrad.Name = "btnDodajGrad";
            this.btnDodajGrad.Size = new System.Drawing.Size(98, 28);
            this.btnDodajGrad.TabIndex = 21;
            this.btnDodajGrad.Text = "Dodaj Grad";
            this.btnDodajGrad.UseVisualStyleBackColor = true;
            this.btnDodajGrad.Click += new System.EventHandler(this.btnDodajGrad_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ShabanRent.Properties.Resources.logo_circle_brand_angle_eye_icon_png_viewed_accomms;
            this.pictureBox2.Location = new System.Drawing.Point(897, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // picBoxSlika
            // 
            this.picBoxSlika.Location = new System.Drawing.Point(12, 12);
            this.picBoxSlika.Name = "picBoxSlika";
            this.picBoxSlika.Size = new System.Drawing.Size(248, 344);
            this.picBoxSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSlika.TabIndex = 2;
            this.picBoxSlika.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Indeks";
            // 
            // txtBrojIndeksa
            // 
            this.txtBrojIndeksa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojIndeksa.Location = new System.Drawing.Point(313, 68);
            this.txtBrojIndeksa.Name = "txtBrojIndeksa";
            this.txtBrojIndeksa.Size = new System.Drawing.Size(282, 27);
            this.txtBrojIndeksa.TabIndex = 22;
            // 
            // RentUShabana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 463);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBrojIndeksa);
            this.Controls.Add(this.btnDodajGrad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbGradovi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblMijesec);
            this.Controls.Add(this.lblKM2);
            this.Controls.Add(this.lblKM);
            this.Controls.Add(this.btnUcitajSliku);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkMijesec);
            this.Controls.Add(this.checkDani);
            this.Controls.Add(this.lblDani);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.numBrojDana);
            this.Controls.Add(this.picBoxSlika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Name = "RentUShabana";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RentUShabana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBrojDana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxSlika;
        private System.Windows.Forms.NumericUpDown numBrojDana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label lblDani;
        private System.Windows.Forms.CheckBox checkDani;
        private System.Windows.Forms.CheckBox checkMijesec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnUcitajSliku;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblMijesec;
        private System.Windows.Forms.Label lblKM2;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog ofdUcitajSlku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGradovi;
        private System.Windows.Forms.Button btnDodajGrad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBrojIndeksa;
    }
}

