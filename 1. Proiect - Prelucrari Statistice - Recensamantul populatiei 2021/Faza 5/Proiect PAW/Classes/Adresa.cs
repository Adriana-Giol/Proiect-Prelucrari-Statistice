using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Classes
{
   public class Adresa
    {
        //DEFINIRE ATRIBUTE
        private String tara;
        private String judet;
        private String localitate;
        private List<String> adresaCompleta;


        //CONSTRUCTOR FARA PARAMETRI
        public Adresa()
        {
            this.tara = "Romania";
            this.judet = "Braila";
            this.localitate = "Braila";
            this.adresaCompleta = new List<string>(new string[] { "Str. Marului", "Bl. 54", "Sc. 3", "Et. 2", "Ap. 14" });
        }


        //CONSTRUCTOR CU PARAMETRI
        public Adresa(string tara, string judet, string localitate, List<string> adresa)
        {
            this.tara = tara;
            this.judet = judet;
            this.localitate = localitate;
            this.adresaCompleta = new List<string>();
            foreach (String a in adresa)
            {
                this.adresaCompleta.Add(a);
            }
        }

        //PROPRIETATI

        public string Tara { get => tara; set => tara = value; }
        public string Judet { get => judet; set => judet = value; }
        public string Localitate { get => localitate; set => localitate = value; }
     


        //TO STRING
        public override string ToString()
        {
            return "Adresa de resedinta a persoanei se afla in tara " + tara
                + " in judetul " + judet
                + ", localitatea " + localitate
                + " si are adresa de resedinta in " + adresaCompleta;
        }
    }
}
