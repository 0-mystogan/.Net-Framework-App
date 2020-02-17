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
    public partial class ShabanMenu : Form
    {
        public ShabanMenu()
        {
            InitializeComponent();
        }

        private void BtnOtvoriDVG_Click(object sender, EventArgs e)
        {
            ShabanAdminDGV shabanAdminDGV = new ShabanAdminDGV();
            shabanAdminDGV.Show();

        }

        private void BtnOtvoriRentUShabana_Click(object sender, EventArgs e)
        {
            RentUShabana rentUShabana = new RentUShabana();
            rentUShabana.ShowDialog();
        }
    }
}
