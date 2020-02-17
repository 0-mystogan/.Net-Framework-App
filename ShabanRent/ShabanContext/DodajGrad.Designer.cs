namespace ShabanRent.ShabanContext
{
    partial class DodajGrad
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
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.btnDodajGrad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGrad
            // 
            this.txtGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrad.Location = new System.Drawing.Point(12, 51);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(274, 30);
            this.txtGrad.TabIndex = 0;
            // 
            // btnDodajGrad
            // 
            this.btnDodajGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajGrad.Location = new System.Drawing.Point(13, 96);
            this.btnDodajGrad.Name = "btnDodajGrad";
            this.btnDodajGrad.Size = new System.Drawing.Size(273, 70);
            this.btnDodajGrad.TabIndex = 1;
            this.btnDodajGrad.Text = "DODAJ";
            this.btnDodajGrad.UseVisualStyleBackColor = true;
            this.btnDodajGrad.Click += new System.EventHandler(this.btnDodajGrad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unesite grad";
            // 
            // DodajGrad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajGrad);
            this.Controls.Add(this.txtGrad);
            this.Name = "DodajGrad";
            this.Text = "DodajGrad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.Button btnDodajGrad;
        private System.Windows.Forms.Label label1;
    }
}