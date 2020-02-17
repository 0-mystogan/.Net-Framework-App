using ShabanRent.ShabanContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShabanRent
{
    public partial class ViewStudenta : Form
    {
        private Student student;
        public ViewStudenta()
        {
            InitializeComponent();
            student = new Student();
        }

        public ViewStudenta(Student student):this()
        {
            this.student = student;
            UcitajPodatkeOStudnetu();
        }

        private void UcitajPodatkeOStudnetu()
        {
            try
            {
                txtVIme.Text = student.Ime;
                txtVPrezime.Text = student.Prezime;
                txtVKod.Text = student.Kod;
                if (student.Slika != null)
                    pbSlikaStudenta.Image = ImageHelper.FromByteToImage(student.Slika);
                else
                    lblNemaSlike.Text = "Nema Slike";
                lblImeStudneta.Text = $"{student.Ime} {student.Prezime}";
                if (student.Dani < 30)
                {
                    lblKMIzracunato.Text = student.Platiti;
                    lblBrojDana.Text = student.Dani.ToString() + " dana";
                }
                else
                {
                    lblKMIzracunato.Text = student.Platiti;
                    lblBrojDana.Text = "mijesec dana";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Grska -> {ex.Message}");
            }
        }

        private void ViewStudenta_Load(object sender, EventArgs e)
        {

        }

        private void PbPokaziKod_Click(object sender, EventArgs e)
        {
            char prazan = new char();
            if(txtVKod.PasswordChar == prazan)
            {
                txtVKod.PasswordChar = '*';
            }
            else
            {
                txtVKod.PasswordChar = prazan;
            }
        }
    }
}
