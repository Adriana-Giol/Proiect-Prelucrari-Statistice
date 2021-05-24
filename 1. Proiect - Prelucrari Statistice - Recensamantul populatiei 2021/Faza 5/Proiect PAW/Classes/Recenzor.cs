using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Classes
{
    public class Recenzor : Persoana
    {
        private string regiuneRecenzata;
        private string judetRecenzat;
        private string localitateRecenzata;
        private List<Recenzat> listaRecenzati;


        //CONSTRUCTOR FARA PARAMETRI
        public Recenzor() : base()
        {
            this.regiuneRecenzata = "";
            this.localitateRecenzata = "";
            this.judetRecenzat = "";
            this.listaRecenzati = new List<Recenzat>();

        }

        public Recenzor(List<string> numeComplet, string cnp, DateTime dataNasterii, bool sex, string regiuneRecenzata, string judetRecenzat, string localitateRecenzata, List<Recenzat> listaRecenzati)
                : base(numeComplet, cnp, dataNasterii, sex)
        {
            this.regiuneRecenzata = regiuneRecenzata;
            this.judetRecenzat = judetRecenzat;
            this.localitateRecenzata = localitateRecenzata;
            this.listaRecenzati = new List<Recenzat>();
            foreach (Recenzat r in listaRecenzati)
                this.listaRecenzati.Add(r);
        }

        //PROPRIETATI
        public string RegiuneRecenzata { get => regiuneRecenzata; set => regiuneRecenzata = value; }
        public string JudetRecenzat { get => judetRecenzat; set => judetRecenzat = value; }
        public string LocalitateRecenzata { get => localitateRecenzata; set => localitateRecenzata = value; }
        public List<Recenzat> ListaRecenzati { get => listaRecenzati; set => listaRecenzati = value; }


        //TO STRING
        public override string ToString()
        {
            string afisare1 = ".Persoana se ocupa de recenzarea zonei " + regiuneRecenzata
                 + " din localitatea" + localitateRecenzata + ", judetul " + judetRecenzat;

            string afisare2 = "Recenzorul a colectat datele persoanele de la urmatoarele persoane: ";
            foreach (Recenzat r in listaRecenzati)
            {
                afisare2 += r.ToString();
            }

            return base.ToString() + afisare1 + afisare2;
        }


        public override void calculareVarstaActuala()
        {
            throw new NotImplementedException();
        }

    }

}
