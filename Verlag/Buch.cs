using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    public class Buch
    {
        private string titel;
        private string autor;
        private int auflage;

        public Buch(string Autor, string Titel) 
        {
            this.Autor = Autor;
            this.Titel = Titel;

            this.Auflage = 1;
        }


        public Buch(string Autor, string Titel, int Auflage) :this(Autor, Titel)
        {
            this.Auflage = Auflage;
        }

        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public int Auflage
        {
            get { return auflage; }
            set { auflage = value; }
        }





    }
}
