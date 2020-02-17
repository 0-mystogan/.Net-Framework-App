using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShabanRent.ShabanContext
{
    public class MBox
    {
        public static void mBox(Exception ex)
        {
            MessageBox.Show($"{ex.Message}\n{ex.InnerException?.Message}", "Greska",MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 
    }
}
