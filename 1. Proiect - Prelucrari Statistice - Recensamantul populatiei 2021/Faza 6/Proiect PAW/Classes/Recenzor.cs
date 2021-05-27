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
        private string directorRegional;



        //CONSTRUCTOR FARA PARAMETRI
        public Recenzor() : base()
        {
            this.codRecenzor = " ";
            this.regiuneRecenzata = " ";
            this.localitateRecenzata = " ";
            this.judetRecenzat = " ";
            this.directorRegional = " ";


        }

        public Recenzor(string codRecenzor, string numeComplet, DateTime dataNasterii, string sex, string regiuneRecenzata, string judetRecenzat, string localitateRecenzata, string directorRegional)
                : base(numeComplet, dataNasterii, sex)
        {
            this.codRecenzor = codRecenzor;
            this.regiuneRecenzata = regiuneRecenzata;
            this.judetRecenzat = judetRecenzat;
            this.localitateRecenzata = localitateRecenzata;
            this.directorRegional = directorRegional;
        }


        //PROPRIETATI
        public string CodRecenzor { get => codRecenzor; set => codRecenzor = value; }
        public string RegiuneRecenzata { get => regiuneRecenzata; set => regiuneRecenzata = value; }
        public string JudetRecenzat { get => judetRecenzat; set => judetRecenzat = value; }
        public string LocalitateRecenzata { get => localitateRecenzata; set => localitateRecenzata = value; }
        public string DirectorRegional { get => directorRegional; set => directorRegional = value; }



        //TO STRING
        public override string ToString()
        {
            string afisare1 = " se ocupa de recenzarea zonei " + regiuneRecenzata + ", judetul " + judetRecenzat
                  + ", localitatea " + localitateRecenzata + "." + Environment.NewLine
                  + " Recenzorul are codul " + codRecenzor;


            return base.ToString() + afisare1;
        }


        public override void calculareVarstaActuala()
        {
            throw new NotImplementedException();
        }

    }

}