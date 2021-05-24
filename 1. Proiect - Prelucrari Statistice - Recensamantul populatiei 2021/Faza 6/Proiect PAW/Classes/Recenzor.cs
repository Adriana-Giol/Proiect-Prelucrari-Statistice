using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Classes
{
    public class Recenzor : Persoana
    {
        private string codRecenzor;
        private string regiuneRecenzata;
        private string judetRecenzat;
        private string localitateRecenzata;



        //CONSTRUCTOR FARA PARAMETRI
        public Recenzor() : base()
        {
            this.codRecenzor = " ";
            this.regiuneRecenzata = " ";
            this.localitateRecenzata = " ";
            this.judetRecenzat = " ";
     

        }

        public Recenzor(string codRecenzor, string numeComplet, DateTime dataNasterii, string sex, string regiuneRecenzata, string judetRecenzat, string localitateRecenzata)
                : base(numeComplet, dataNasterii, sex)
        {
            this.codRecenzor = codRecenzor;
            this.regiuneRecenzata = regiuneRecenzata;
            this.judetRecenzat = judetRecenzat;
            this.localitateRecenzata = localitateRecenzata;
        }


        //PROPRIETATI
        public string CodRecenzor { get => codRecenzor; set => codRecenzor = value; }
        public string RegiuneRecenzata { get => regiuneRecenzata; set => regiuneRecenzata = value; }
        public string JudetRecenzat { get => judetRecenzat; set => judetRecenzat = value; }
        public string LocalitateRecenzata { get => localitateRecenzata; set => localitateRecenzata = value; }
 


        //TO STRING
        public override string ToString()
        {
            string afisare1 = ".Persoana se ocupa de recenzarea zonei " + regiuneRecenzata
                 + " din localitatea" + localitateRecenzata + ", judetul " + judetRecenzat;


            return base.ToString() + afisare1;
        }


        public override void calculareVarstaActuala()
        {
            throw new NotImplementedException();
        }

    }

}
