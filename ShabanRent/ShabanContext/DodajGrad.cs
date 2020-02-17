using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShabanRent.ShabanContext
{
    public partial class DodajGrad : Form
    {
        public DodajGrad()
        {
            InitializeComponent();
        }

        private void btnDodajGrad_Click(object sender, EventArgs e)
        {
            Grad grad = new Grad();
            grad.Naziv = txtGrad.Text;

            if(ProvjeriDaLiImaGrad(grad))
            {
                LoadDataSource.ShabanDbContext.Grad.Add(grad);
                LoadDataSource.ShabanDbContext.SaveChanges();
                Close();
            }
            txtGrad.Text = null;
        }

        private bool ProvjeriDaLiImaGrad(Grad grad)
        {
            if (LoadDataSource.ShabanDbContext.Grad.Where(x => x.Naziv == grad.Naziv).Count() > 0)
            {
                MessageBox.Show($"Grad: {grad.Naziv} već postoji u bazi podataka!");
                return false;
            }
            return true;
        }
    }
}
