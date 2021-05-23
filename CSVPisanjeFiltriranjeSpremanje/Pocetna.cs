using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVPisanjeFiltriranjeSpremanje
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void UnosTextBox_Click(object sender, EventArgs e)
        {
            Unos FormUnos = new Unos();
            FormUnos.Show();
        }

        private void PrikazButton_Click(object sender, EventArgs e)
        {
            Pregled FormPregled = new Pregled();
            FormPregled.Show();
        }
    }
}
