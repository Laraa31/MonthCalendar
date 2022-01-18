using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monCal_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnTermin_Click(object sender, EventArgs e)
        {
            TimeSpan period=monCal.SelectionEnd- monCal.SelectionStart;

            if (period.Days < 1)
            {
                MessageBox.Show("Niste odabrali termin, odaberite termin pomoću tipke SHIFT!",
                               "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Rezervirali ste period od " + 
                    monCal.SelectionStart.ToShortDateString()+ " do "
                    + monCal.SelectionEnd.ToShortDateString()+".",
                    "Rezervacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
    }
}
