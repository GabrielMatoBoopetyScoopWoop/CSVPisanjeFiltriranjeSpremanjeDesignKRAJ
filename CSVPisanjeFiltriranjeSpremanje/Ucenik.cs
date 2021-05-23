using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVPisanjeFiltriranjeSpremanje
{
    class Ucenik
    {
        public Ucenik(string ime, string prezime, string email, string razred)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.razred = razred;
        }

        public string ime { get; set; }
        public string prezime { get; set; }
        public string email { get; set; }
        public string razred { get; set; }
    }
}
