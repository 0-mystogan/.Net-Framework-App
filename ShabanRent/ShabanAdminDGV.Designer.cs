namespace ShabanRent
{
    partial class ShabanAdminDGV
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
            this.dgvStudneti = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izmijeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rbMjesecni = new System.Windows.Forms.RadioButton();
            this.rbDani = new System.Windows.Forms.RadioButton();
            this.rbSve = new System.Windows.Forms.RadioButton();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.cmbSortiraj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudneti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudneti
            // 
            this.dgvStudneti.AllowUserToAddRows = false;
            this.dgvStudneti.AllowUserToDeleteRows = false;
            this.dgvStudneti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudneti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Grad,
            this.Dani,
            this.Kod,
            this.Izmijeni});
            this.dgvStudneti.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStudneti.Location = new System.Drawing.Point(12, 74);
            this.dgvStudneti.Name = "dgvStudneti";
            this.dgvStudneti.ReadOnly = true;
            this.dgvStudneti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudneti.Size = new System.Drawing.Size(738, 320);
            this.dgvStudneti.TabIndex = 0;
            this.dgvStudneti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStudneti_CellContentClick);
            this.dgvStudneti.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStudneti_CellContentDoubleClick);
            this.dgvStudneti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvStudneti_MouseDoubleClick);
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "Grad";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // Dani
            // 
            this.Dani.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dani.DataPropertyName = "Dani";
            this.Dani.HeaderText = "Ostaje dana";
            this.Dani.Name = "Dani";
            this.Dani.ReadOnly = true;
            // 
            // Kod
            // 
            this.Kod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kod.DataPropertyName = "Kod";
            this.Kod.HeaderText = "Kod pristupa";
            this.Kod.Name = "Kod";
            this.Kod.ReadOnly = true;
            // 
            // Izmijeni
            // 
            this.Izmijeni.HeaderText = "Izmijeni";
            this.Izmijeni.Name = "Izmijeni";
            this.Izmijeni.ReadOnly = true;
            this.Izmijeni.Text = "Izmijeni";
            this.Izmijeni.UseColumnTextForButtonValue = true;
            // 
            // rbMjesecni
            // 
            this.rbMjesecni.AutoSize = true;
            this.rbMjesecni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMjesecni.Location = new System.Drawing.Point(412, 39);
            this.rbMjesecni.Name = "rbMjesecni";
            this.rbMjesecni.Size = new System.Drawing.Size(88, 22);
            this.rbMjesecni.TabIndex = 1;
            this.rbMjesecni.TabStop = true;
            this.rbMjesecni.Text = "Mijesecni";
            this.rbMjesecni.UseVisualStyleBackColor = true;
            this.rbMjesecni.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbMjesecni_MouseClick);
            // 
            // rbDani
            // 
            this.rbDani.AutoSize = true;
            this.rbDani.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDani.Location = new System.Drawing.Point(503, 39);
            this.rbDani.Name = "rbDani";
            this.rbDani.Size = new System.Drawing.Size(56, 22);
            this.rbDani.TabIndex = 2;
            this.rbDani.TabStop = true;
            this.rbDani.Text = "Dani";
            this.rbDani.UseVisualStyleBackColor = true;
            this.rbDani.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbDani_MouseClick);
            // 
            // rbSve
            // 
            this.rbSve.AutoSize = true;
            this.rbSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSve.Location = new System.Drawing.Point(355, 39);
            this.rbSve.Name = "rbSve";
            this.rbSve.Size = new System.Drawing.Size(51, 22);
            this.rbSve.TabIndex = 3;
            this.rbSve.TabStop = true;
            this.rbSve.Text = "Sve";
            this.rbSve.UseVisualStyleBackColor = true;
            this.rbSve.CheckedChanged += new System.EventHandler(this.rbSve_CheckedChanged);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretrazi.Location = new System.Drawing.Point(12, 36);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(214, 27);
            this.txtPretrazi.TabIndex = 4;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(232, 34);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(96, 27);
            this.btnPretrazi.TabIndex = 5;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // cmbSortiraj
            // 
            this.cmbSortiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSortiraj.FormattingEnabled = true;
            this.cmbSortiraj.Location = new System.Drawing.Point(597, 38);
            this.cmbSortiraj.Name = "cmbSortiraj";
            this.cmbSortiraj.Size = new System.Drawing.Size(153, 26);
            this.cmbSortiraj.TabIndex = 6;
            this.cmbSortiraj.SelectedValueChanged += new System.EventHandler(this.cmbSortiraj_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pretraži";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(594, 13);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(53, 17);
            this.l.TabIndex = 8;
            this.l.Text = "Sortiraj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Odaberi koji ostaju mijesec/dane";
            // 
            // ShabanAdminDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 412);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSortiraj);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.rbSve);
            this.Controls.Add(this.rbDani);
            this.Controls.Add(this.rbMjesecni);
            this.Controls.Add(this.dgvStudneti);
            this.Name = "ShabanAdminDGV";
            this.Text = "ShabanAdminDGV";
            this.Load += new System.EventHandler(this.ShabanAdminDGV_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShabanAdminDGV_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudneti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudneti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dani;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
        private System.Windows.Forms.DataGridViewButtonColumn Izmijeni;
        private System.Windows.Forms.RadioButton rbMjesecni;
        private System.Windows.Forms.RadioButton rbDani;
        private System.Windows.Forms.RadioButton rbSve;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.ComboBox cmbSortiraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label3;
    }
}