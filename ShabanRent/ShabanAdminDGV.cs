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
    public partial class ShabanAdminDGV : Form
    {
        public ShabanAdminDGV()
        {
            InitializeComponent();
            dgvStudneti.AutoGenerateColumns = false;
        }

        private void ShabanAdminDGV_Load(object sender, EventArgs e)
        {
            rbSve.Checked = true;
            LoadDataSource.LoadData(dgvStudneti);
            cmbSortiraj.DataSource = Sortiraj.Sortiranja;

        }

        private void DgvStudneti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DgvStudneti_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Student student = dgvStudneti.SelectedRows[0].DataBoundItem as Student;
            Form form = null;
            if (student != null)
            {
                Text = student.ToString();
                if (e.ColumnIndex == 5)
                {
                    form = new RentUShabana(student);
                }else
                    form = new ViewStudenta(student);
                form.ShowDialog();
                LoadDataSource.LoadData(dgvStudneti);
            }
        }

        private void DgvStudneti_MouseDoubleClick(object sender, MouseEventArgs e)
        {

           
        }

        private void ShabanAdminDGV_MouseClick(object sender, MouseEventArgs e)
        {

           // LoadDataSource.LoadData(dgvStudneti);
        }

        private void rbSve_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataSource.LoadData(dgvStudneti);
        }

        private void rbMjesecni_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbMjesecni.Checked)
                LoadDataSource.LoadCertainData(dgvStudneti, rbMjesecni, "M");
        }

        private void rbDani_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbDani.Checked)
                 LoadDataSource.LoadCertainData(dgvStudneti, rbDani, "D");
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if(txtPretrazi.Text != null)
            {
                string filter = txtPretrazi.Text.ToLower();
                List<Student> rezultat = LoadDataSource.ShabanDbContext.Studenti
                    .Where(x=>x.Ime.ToLower().Contains(filter) || 
                    x.Prezime.ToLower().Contains(filter) || x.Grad.Naziv.ToLower().Contains(filter)).ToList();
                if (rbMjesecni.Checked)
                    LoadDataSource.LoadCertainData(dgvStudneti, rbMjesecni, "M", rezultat);
                else if (rbDani.Checked)
                    LoadDataSource.LoadCertainData(dgvStudneti, rbDani, "D", rezultat);
                else
                LoadDataSource.LoadData(dgvStudneti, rezultat);
            }
        }

        private void cmbSortiraj_SelectedValueChanged(object sender, EventArgs e)
        {
            string key = cmbSortiraj.SelectedValue.ToString();
            if (key == "uzlazno") LoadDataSource.LoadCertainData(dgvStudneti, cmbSortiraj, key);
            else if (key == "silazno") LoadDataSource.LoadCertainData(dgvStudneti, cmbSortiraj, key);
            //else LoadDataSource.LoadData(dgvStudneti);
            
        }
    }
}
