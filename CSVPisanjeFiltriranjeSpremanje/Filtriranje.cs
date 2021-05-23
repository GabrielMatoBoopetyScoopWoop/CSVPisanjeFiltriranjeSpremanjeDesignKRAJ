using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSVPisanjeFiltriranjeSpremanje
{
    public partial class Filtriranje : Form
    {
        string Putanja = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "csvTransformer.csv");
        string PutanjaFiltrirano = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "csvTransformerFiltrirano.csv");
        public Filtriranje()
        {
            InitializeComponent();
        }

        private void ZavrsiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FiltrirajButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(Putanja))
            {
                using (StreamReader sr = new StreamReader(Putanja))
                {
                    using (StreamWriter sw = new StreamWriter(PutanjaFiltrirano))
                    {
                        sw.WriteLine("Ime,Prezime,Email,Razred");
                        if (sr.ReadToEnd().Contains(ImeTextBox.Text + "," + PrezimeTextBox.Text + "," + EmailTextBox.Text + "," + RazredComboBox.Text))
                        {
                            sw.WriteLine(ImeTextBox.Text + "," + PrezimeTextBox.Text + "," + EmailTextBox.Text + "," + RazredComboBox.Text);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Izradite novi dokument", "Nema dokumenta", MessageBoxButtons.OK);
            }
        }
    }
}
