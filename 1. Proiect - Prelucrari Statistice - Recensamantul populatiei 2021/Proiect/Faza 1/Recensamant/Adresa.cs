using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recensamant
{
    class Adresa
    {
        private String tara;
        private String judet;
        private String localitate;
        private String strada;
        private String bloc;
        private int nr;
        private int scara;
        private int etaj;
        private int apartament;

     
        public Adresa(string tara, string judet, string localitate, string strada, int nr, string bloc, int scara, int etaj, int apartament)
        {
            this.tara = tara;
            this.judet = judet;
            this.localitate = localitate;
            this.strada = strada;
            this.nr = nr;
            this.bloc = bloc;
            this.Scara = scara;
            this.etaj = etaj;
            this.apartament = apartament;
        }

        public string Tara { get => tara; set => tara = value; }
        public string Judet { get => judet; set => judet = value; }
        public string Localitate { get => localitate; set => localitate = value; }
        public string Strada { get => strada; set => strada = value; }
        public int Nr { get => nr; set => nr = value; }
        public string Bloc { get => bloc; set => bloc = value; }
        public int Scara { get => scara; set => scara = value; }
        public int Etaj { get => etaj; set => etaj = value; }
        public int Apartament { get => apartament; set => apartament = value; }

      
    }
}
