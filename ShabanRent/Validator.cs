using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShabanRent
{
    public class Validator
    {
        public const string porukaString = "Obavezno polje!";
        public const string porukaNum = "Ne možete ostati NULA dana!";
        public const string porukaGrad = "Obavezan unos Grad!";
        public static bool ObavezanUnos(Control control, ErrorProvider err, string poruka)
        {
            bool validno = true;
            if (control is TextBox && string.IsNullOrEmpty((control as TextBox).Text))
                validno = false;
            else if (control is NumericUpDown && (control as NumericUpDown).Value == 0)
                validno = false;
            else if (control is CheckBox && !(control as CheckBox).Checked)
                validno = false;
            else if (control is ComboBox && (control as ComboBox).SelectedItem == null)
                validno = false;

            if (!validno)
            {
                err.SetError(control, poruka);
                return false;
            }
            err.Clear();
            return true;
        }

    }
}
