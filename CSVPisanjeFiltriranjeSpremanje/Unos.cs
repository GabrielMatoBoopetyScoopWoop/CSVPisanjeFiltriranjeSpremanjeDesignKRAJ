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
using System.Text.RegularExpressions;
namespace CSVPisanjeFiltriranjeSpremanje
{
    public partial class Unos : Form
    {
        string Putanja = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "csvTransformer.csv");
        string PutanjaFiltrirano = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "csvTransformerFiltrirano.csv");
        List<Ucenik> UcenikObj = new List<Ucenik>();
        public Unos()
        {
            InitializeComponent();
        }
        public bool IsAlphabets(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                return false;

            for (int i = 0; i < inputString.Length; i++)
                if (!char.IsLetter(inputString[i]))
                    return false;
            return true;
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ZavrsiButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(ImeTextBox.Text) || !string.IsNullOrEmpty(PrezimeTextBox.Text) || !string.IsNullOrEmpty(EmailTextBox.Text) || !string.IsNullOrEmpty(RazredComboBox.Text))
            {
                if (!File.Exists(Putanja))
                {
                    File.Delete(PutanjaFiltrirano);
                    using (StreamWriter sw = File.CreateText(Putanja))
                    {
                        sw.WriteLine("Ime,Prezime,Email,Razred");
                        foreach (Ucenik ObjektUcenik in UcenikObj)
                        {
                            sw.WriteLine(ObjektUcenik.ime + "," + ObjektUcenik.prezime + "," + ObjektUcenik.email + "," + ObjektUcenik.razred);
                        }
                    }
                }
                else
                {
                    File.Delete(PutanjaFiltrirano);
                    File.Delete(Putanja);
                    using (StreamWriter sw = File.CreateText(Putanja))
                    {
                        sw.WriteLine("Ime,Prezime,Email,Razred");
                        foreach (Ucenik ObjektUcenik in UcenikObj)
                        {
                            sw.WriteLine(ObjektUcenik.ime + "," + ObjektUcenik.prezime + "," + ObjektUcenik.email + "," + ObjektUcenik.razred);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Napravili ste prazan upis, pokusajte ponovno", "Pogresan upis!");
            }
            Close();
        }

        private void UnosButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmailTextBox.Text.Contains('@') && IsAlphabets(ImeTextBox.Text) && IsAlphabets(PrezimeTextBox.Text) && Convert.ToInt32(RazredComboBox.Text) > 0)
                {
                    Ucenik ObjektUcenik = new Ucenik(ImeTextBox.Text, PrezimeTextBox.Text, EmailTextBox.Text, RazredComboBox.Text);
                    UcenikObj.Add(ObjektUcenik);
                    ImeTextBox.Clear();
                    PrezimeTextBox.Clear();
                    EmailTextBox.Clear();
                    RazredComboBox.SelectedIndex = -1;
                    MessageBox.Show("Podatci su unoseni", "Uspijeh!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Napravili ste pogresan upis, pokusajte ponovno." + System.Environment.NewLine, "Pogresan upis!");
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Napravili ste pogresan upis, pokusajte ponovno." + System.Environment.NewLine, "Pogresan upis!");
            }
        }
    }
}
