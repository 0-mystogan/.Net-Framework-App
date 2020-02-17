namespace ShabanRent
{
    partial class ShabanMenu
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
            this.btnOtvoriRentUShabana = new System.Windows.Forms.Button();
            this.btnOtvoriDVG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOtvoriRentUShabana
            // 
            this.btnOtvoriRentUShabana.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtvoriRentUShabana.Location = new System.Drawing.Point(372, 12);
            this.btnOtvoriRentUShabana.Name = "btnOtvoriRentUShabana";
            this.btnOtvoriRentUShabana.Size = new System.Drawing.Size(293, 282);
            this.btnOtvoriRentUShabana.TabIndex = 0;
            this.btnOtvoriRentUShabana.Text = "Dodaj studneta";
            this.btnOtvoriRentUShabana.UseVisualStyleBackColor = true;
            this.btnOtvoriRentUShabana.Click += new System.EventHandler(this.BtnOtvoriRentUShabana_Click);
            // 
            // btnOtvoriDVG
            // 
            this.btnOtvoriDVG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtvoriDVG.Location = new System.Drawing.Point(12, 12);
            this.btnOtvoriDVG.Name = "btnOtvoriDVG";
            this.btnOtvoriDVG.Size = new System.Drawing.Size(293, 282);
            this.btnOtvoriDVG.TabIndex = 1;
            this.btnOtvoriDVG.Text = "Pregledaj studente";
            this.btnOtvoriDVG.UseVisualStyleBackColor = true;
            this.btnOtvoriDVG.Click += new System.EventHandler(this.BtnOtvoriDVG_Click);
            // 
            // ShabanMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 323);
            this.Controls.Add(this.btnOtvoriDVG);
            this.Controls.Add(this.btnOtvoriRentUShabana);
            this.Name = "ShabanMenu";
            this.Text = "ShabanAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOtvoriRentUShabana;
        private System.Windows.Forms.Button btnOtvoriDVG;
    }
}