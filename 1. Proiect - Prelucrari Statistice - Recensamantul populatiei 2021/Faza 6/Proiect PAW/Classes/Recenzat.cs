using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Recenzat : Persoana
    {
        //DEFINIRE ATRIBUTE
        private string cnp;
        private string stareCivila;
        private string nationalitate;
        private Locuinta locuinta;
        private IdentitateCulturala identitateCulturala;


        //CONSTRUCTOR FARA PARAMETRI
        public Recenzat() : base()
        {
            this.cnp = " ";
            this.stareCivila = "Necasatorit";
            this.nationalitate = "Romana";
            this.locuinta = new Locuinta();
            this.identitateCulturala = new IdentitateCulturala();
        }



        //CONSTRUCTOR CU PARAMETRI
        public Recenzat(string numeComplet, DateTime dataNasterii, string sex, string cnp, string stareCivila, string nationalitate, Locuinta locuinta, IdentitateCulturala identitateCulturala)
            : base(numeComplet, dataNasterii, sex)
        {
            this.cnp = cnp;
            this.stareCivila = stareCivila;
            this.nationalitate = nationalitate;
            this.locuinta = new Locuinta();
            this.identitateCulturala = new IdentitateCulturala();
        }


        //PROPRIETATI
        public string StareCivila { get => stareCivila; set => stareCivila = value; }
        public string Nationalitate { get => nationalitate; set => nationalitate = value; }
        public string Cnp { get => cnp; set => cnp = value; }
        internal Locuinta Locuinta { get => locuinta; set => locuinta = value; }
        internal IdentitateCulturala IdentitateCulturala { get => identitateCulturala; set => identitateCulturala = value; }


        //IMPLEMENTARE METODA ABSTRACTA
        public override void calculareVarstaActuala()
        {
            throw new NotImplementedException();
        }


        //TO STRING
        public override string ToString()
        {
            return base.ToString() + " si este " + stareCivila + " avand nationalitatea " + nationalitate;
        }
    }
}