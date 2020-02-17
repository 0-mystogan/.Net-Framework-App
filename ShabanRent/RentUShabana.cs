using ShabanRent.ShabanContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Controls;
using System.Windows.Forms;

namespace ShabanRent
{
    public partial class RentUShabana : Form
    {
        private Student student;
        public bool Edit { get; set; }
        public RentUShabana()
        {
            InitializeComponent();
            student = new Student();
        }

        public RentUShabana(Student student) : this()
        {
            this.student = student;
            UcitajPodatkeOStudentu();
            Edit = true;
        }

        private void UcitajPodatkeOStudentu()
        {
            try
            {
                txtIme.Text = student.Ime;
                txtPrezime.Text = student.Prezime;
                if(student.Dani == 30)
                {
                    checkMijesec.CheckState = CheckState.Checked;
                    
                }
                else
                {
                    checkDani.CheckState = CheckState.Checked;
                    numBrojDana.Value = student.Dani;
                    
                }
                txtKod.Text = student.Kod;
                if(student.Slika != null)
                    picBoxSlika.Image = ImageHelper.FromByteToImage(student.Slika);
                
                cmbGradovi.SelectedItem = student.Grad;
            }
            catch (Exception ex)
            {
                MBox.mBox(ex);
            }
        }

        private void RentUShabana_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(student.Kod) && string.IsNullOrEmpty(txtIme.Text) && string.IsNullOrEmpty(txtPrezime.Text))
            {
                txtKod.Text = GenerisiKod(7);
                student.Kod = txtKod.Text;
            }
            GeneresiBrojIndeksa();
            //UcitajGradiove();
        }

        private void GeneresiBrojIndeksa()
        {
            if(LoadDataSource.ShabanDbContext.Studenti.Count() > 0) 
            {
                List<Student> students = LoadDataSource.ShabanDbContext.Studenti.ToList();
                
                int Prethodni = students.Max(s => s.BrojIndeksa);
                ++Prethodni;
                txtBrojIndeksa.Text = $"IB{Prethodni}";

            }
            else
            {
                int start = 190000;
                txtBrojIndeksa.Text = $"IB{start}";
            }

        }

        private void UcitajGradiove()
        {
            try
            {
                cmbGradovi.DataSource = LoadDataSource.ShabanDbContext.Grad.ToList();
                cmbGradovi.DisplayMember = "Naziv";
                cmbGradovi.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MBox.mBox(ex);       
            }
           
        }

        private void BtnPrijava_Click(object sender, EventArgs e)
        {
            if (ValirajUnosString() && ProvjeriDaLiPostojiStudent()) {
                student.Ime = txtIme.Text;
                student.Prezime = txtPrezime.Text;
                student.BrojIndeksa = SpremiIntIndeks();
                if(picBoxSlika.Image != null)
                    student.Slika = ImageHelper.FromImageToByte(picBoxSlika.Image);
                student.Grad = cmbGradovi.SelectedItem as Grad;

                if (checkDani.Checked)
                {
                    Validator.ObavezanUnos(numBrojDana, errorProvider1, Validator.porukaNum);
                    student.Dani = numBrojDana.Value;
                    student.Platiti = (numBrojDana.Value * 10).ToString() + "KM";
                    double dani = (double)numBrojDana.Value;
                    UnesiDatum(dani);
                }
                else
                {
                    student.Dani = 30;
                    student.Platiti = "180KM";
                    UnesiDatum(30);
                }
                

                if (!Edit)
                {
                    //student.Id = ListaKorisnika.PrijavljeniKorisnici.Count + 1;
                    //ListaKorisnika.PrijavljeniKorisnici.Add(student);
                    LoadDataSource.ShabanDbContext.Studenti.Add(student);
                    LoadDataSource.ShabanDbContext.SaveChanges();
                    MessageBox.Show($"{student}");
                }
                else
                {
                    LoadDataSource.ShabanDbContext.Entry(student).State = EntityState.Modified;
                    LoadDataSource.ShabanDbContext.SaveChanges();
                    MessageBox.Show("Editovanje Uspiješno završeno!");
                }
                DialogResult = DialogResult.OK;
                //MessageBox.Show($"{korisnik} i uspjepno je logiran");
                Close();
            }
        }

        private int SpremiIntIndeks()
        {
            string BrojIndeksa = txtBrojIndeksa.Text;
            BrojIndeksa = BrojIndeksa.Remove(0, 2);
            int intBrojIndeksa = Int32.Parse(BrojIndeksa);
            return intBrojIndeksa;
        }

        private bool ProvjeriDaLiPostojiStudent()
        {
            int indeks = SpremiIntIndeks();
            if(LoadDataSource.ShabanDbContext.Studenti.Count() > 0)
                if (LoadDataSource.ShabanDbContext.Studenti.Where(s => s.BrojIndeksa.Equals(indeks)).Count() > 0)
                {
                    MessageBox.Show($"Student sa indeksom IB{indeks} već postoji u bazi!");
                    return false;
                }

            return true;
        }

        private void UnesiDatum(double dani)
        {
            DateTime danas = DateTime.Now;
            string DatumDolazka = danas.ToString("dd.MM.yyyy");
            danas = DateTime.Now.AddDays(dani);
            string DatumOdlazka = danas.ToString("dd.MM.yyyy");
            //MessageBox.Show($"{stDanas}\n{staddDan}");
            Datum datum = new Datum();
            datum.DatumDolazka = DatumDolazka;
            datum.DatumOdlazka = DatumOdlazka;

            LoadDataSource.ShabanDbContext.Datum.Add(datum);
            LoadDataSource.ShabanDbContext.SaveChanges();

            student.Datum = datum;
    
        }

        private string GenerisiKod( int brojZnakova)
        {

            string dozvoljenikarakteri = "1HG3452F54Q3YT4B4H5Z5J6L2234234J2AX8F7R8G75Y23H4HD3459J3L09KL0KJT6QKXC345H36SG46KQH85JUYX";
            string noviKod = string.Empty;
            Random random = new Random();
            int lokacija = 0;
            for (int i = 0; i < brojZnakova; i++)
            {
                lokacija = random.Next(0, dozvoljenikarakteri.Length);
                noviKod += dozvoljenikarakteri[lokacija];
            }
            return $"#{noviKod}";
        }

        private bool ValirajUnosString()
        {
            return Validator.ObavezanUnos(txtIme, errorProvider1, Validator.porukaString) &&
                Validator.ObavezanUnos(txtPrezime, errorProvider1, Validator.porukaString) &&
                Validator.ObavezanUnos(cmbGradovi, errorProvider1, Validator.porukaGrad);
        }

        private void CheckMijesec_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMijesec.Checked)
            {
                numBrojDana.Visible = false;
                lblKM.Visible = false;
                lblKM2.Visible = false;
                lblDani.Visible = false;
                lblMijesec.Visible = true;
                if (checkDani.Checked)
                    checkDani.Checked = false;
            }

        }

        private void CheckDani_CheckedChanged(object sender, EventArgs e)
        {

            if (checkDani.Checked)
            {
                numBrojDana.Visible = true;
                lblKM.Visible = true;
                lblKM2.Visible = true;
                lblDani.Visible = true;
                lblMijesec.Visible = false;
                if (checkMijesec.Checked)
                    checkMijesec.Checked = false;
            }
        }

        private void NumBrojDana_ValueChanged(object sender, EventArgs e)
        {
            if (ValidirajUnosCheck())
            {
                decimal brojDana = numBrojDana.Value;
                decimal cijenaBoravka = brojDana * 10;
                string cBoravkaString = cijenaBoravka.ToString();
                lblKM.Text = cBoravkaString;
            }else
                numBrojDana.Value = 0;
        }

        private bool ValidirajUnosCheck()
        {
           return  Validator.ObavezanUnos(checkDani, errorProvider1, Validator.porukaString) ||
                    Validator.ObavezanUnos(checkMijesec, errorProvider1, Validator.porukaString);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            char prazan = new char();
            if (txtKod.PasswordChar == prazan)
            {
                txtKod.PasswordChar = '*';
            }
            else
                txtKod.PasswordChar = prazan;
        }

        private void BtnUcitajSliku_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdUcitajSlku.ShowDialog() == DialogResult.OK)
                {
                    string putanjeSlike = ofdUcitajSlku.FileName;
                    Image image = Image.FromFile(putanjeSlike);
                    picBoxSlika.Image = image;
                }
            }
            catch (Exception ex)
            {
                MBox.mBox(ex);
            }

        }

        private void btnDodajGrad_Click(object sender, EventArgs e)
        {
            DodajGrad dodajGrad = new DodajGrad();
            dodajGrad.Show();
            UcitajGradiove();
        }

        private void cmbGradovi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGradovi_MouseClick(object sender, MouseEventArgs e)
        {
            UcitajGradiove();
        }
        
    }
}
