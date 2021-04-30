using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Classes
{
    public class Recenzor : Persoana
    {
        private int nrMape;
        private String zonaRecenzata;
        private String localitateRecenzata;

        //CONSTRUCTOR FARA PARAMETRI
        public Recenzor() : base()
        {
            this.nrMape = 10;
            this.zonaRecenzata = "Radu Negru";
            this.localitateRecenzata = "Braila";
        }

        //CONSTRUCTOR CU PARAMETRI
        public Recenzor(int nrMape, string zonaRecenzata, string localitateRecenzata, string cnp, List<string> numeComplet, bool sex, DateTime dataNasterii)
            : base(cnp, numeComplet, sex, dataNasterii)
        {
            NrMape = nrMape;
            ZonaRecenzata = zonaRecenzata;
            LocalitateRecenzata = localitateRecenzata;

        }

        //PROPRIETATI
        public int NrMape { get => nrMape; set => nrMape = value; }
        public string ZonaRecenzata { get => zonaRecenzata; set => zonaRecenzata = value; }
        public string LocalitateRecenzata { get => localitateRecenzata; set => localitateRecenzata = value; }

        //TO STRING
        public override string ToString()
        {
            return base.ToString()
                + ".Persoana se ocupa de recenzarea zonei " + zonaRecenzata
                + "din localitatea " + localitateRecenzata
                + " avand realizate un numar de " + nrMape + " mape.";
        }


        public override void calculareVarstaActuala()
        {
            throw new NotImplementedException();
        }
    }
      
}
