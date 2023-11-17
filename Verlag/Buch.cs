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

        string[] unerlaubteZeichen = { "", "#", ";", "§", "%"};



        //Konstruktor
        public Buch(string Autor, string titel) 
        {

            for (int i = 0; i < unerlaubteZeichen.Length; i++)
            {
                if (this.Autor == unerlaubteZeichen[i])
                {
                    throw new ArgumentException("Es wurde ein unerlaubtes Zeichen benutzt");
                }
                this.Autor = Autor;

            }
            if (String.IsNullOrEmpty(this.Autor))
            {
                throw new ArgumentException("Es wurde ein unerlaubtes Zeichen benutzt");
            }



            this.titel = titel;
            Auflage = 1;
        }

        //Konstruktttor mit vererbung 
        public Buch(string Autor, string Titel, int Auflage) :this(Autor, Titel)
        {
            this.Auflage = Auflage;
        }




        public string Titel
        {
            get { return titel; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public int Auflage
        {
            get { return auflage; }
            set 
            { //auflage = value; 
                if (value >= 1)
                {
                    auflage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Auflage nummer ist nicht zuläassig");
                }
            }
        }
    }
}
