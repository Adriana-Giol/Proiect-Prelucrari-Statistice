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
        private String strada;
        private int nr;
        private int bloc;
        private int scara;
        private int etaj;
        private int apartament;


        //CONSTRUCTOR FARA PARAMETRI
        public Adresa()
        {
            this.tara = "Romania";
            this.judet = "Braila";
            this.localitate = "Braila";
            this.strada = "Castanului";
            this.nr = 30;
            this.bloc = 52;
            this.scara = 3;
            this.etaj = 2;
            this.apartament = 14;
        }


        //CONSTRUCTOR CU PARAMETRI
        public Adresa(string tara, string judet, string localitate, string strada, int nr, int bloc, int scara, int etaj, int apartament)
        {
            this.tara = tara;
            this.judet = judet;
            this.localitate = localitate;
            this.strada = strada;
            this.nr = nr;
            this.bloc = bloc;
            this.scara = scara;
            this.etaj = etaj;
            this.apartament = apartament;
        }

        //PROPRIETATI

        public string Tara { get => tara; set => tara = value; }
        public string Judet { get => judet; set => judet = value; }
        public string Localitate { get => localitate; set => localitate = value; }
        public string Strada { get => strada; set => strada = value; }
        public int Nr { get => nr; set => nr = value; }
        public int Bloc { get => bloc; set => bloc = value; }
        public int Scara { get => scara; set => scara = value; }
        public int Etaj { get => etaj; set => etaj = value; }
        public int Apartament { get => apartament; set => apartament = value; }


        //TO STRING
        public override string ToString()
        {
            return "Adresa de resedinta a persoanei se afla in tara " + tara
                + " in judetul " + judet
                + ", localitatea " + localitate
                + " avand locuinta pe strada " + strada
                + " la numarul " + nr
                + ", blocul " + bloc
                + ", scara " + scara
                + " la etajul " + etaj
                + ", apartamentul " + apartament;
        }
    }
}
