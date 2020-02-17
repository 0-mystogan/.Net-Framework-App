using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShabanRent.ShabanContext;


namespace ShabanRent
{
    public class LoadDataSource
    {
        public static ShabanRentDbContext ShabanDbContext { get; } = new ShabanRentDbContext();
        public static void LoadData(DataGridView dataGridView, List<Student> students = null)
        {
            try
            {
                dataGridView.DataSource = null;
                dataGridView.DataSource = students ?? ShabanDbContext.Studenti.ToList();
            }
            catch (Exception ex)
            {
                MBox.mBox(ex);
            }

        }

        public static void LoadCertainData(DataGridView dataGridView, Control control, string key, List<Student> students = null)
        {
            try
            {
                if(control is RadioButton && key.Equals("M"))
                {
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = students?.Where(x => (x.Dani == 30)).ToList() ?? ShabanDbContext.Studenti.Where(x => (x.Dani == 30)).ToList();

                }
                else if (control is RadioButton && key.Equals("D"))
                {
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = students?.Where(x => x.Dani < 30).ToList() ?? ShabanDbContext.Studenti.Where(x => x.Dani < 30).ToList();
                }
                else if(control is ComboBox && key.Equals("uzlazno"))
                {
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = ShabanDbContext.Studenti.OrderBy(i => i.Ime).ToList();
                }
                else if (control is ComboBox && key.Equals("silazno"))
                {
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = ShabanDbContext.Studenti.OrderByDescending(i => i.Ime).ToList();
                }

            }
            catch (Exception ex)
            {
                MBox.mBox(ex);
            }

        }
    }
}
