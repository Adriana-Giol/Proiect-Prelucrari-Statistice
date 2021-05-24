using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Recenzat: Persoana
    {
       //DEFINIRE ATRIBUTE
        private String stareCivila;
        private String nationalitate;
        private Locuinta locuinta;
        private IdentitateCulturala identitateCulturala;


        //CONSTRUCTOR FARA PARAMETRI
        public Recenzat():base()
        {
            this.stareCivila = "Necasatorit";
            this.nationalitate = "Romana";
            this.locuinta = new Locuinta();
            this.identitateCulturala = new IdentitateCulturala();
        }

        //CONSTRUCTOR CU PARAMETRI PENTRU CLASA MIGRANT
        public Recenzat(string stareCivila, string nationalitate, Locuinta locuinta, IdentitateCulturala identitateCulturala, string cnp, bool sex, DateTime dataNasterii)
        {
            this.stareCivila = stareCivila;
            this.nationalitate = nationalitate;
            this.locuinta = locuinta;
            this.identitateCulturala = identitateCulturala;
            DataNasterii = dataNasterii;
        }

        //CONSTRUCTOR CU PARAMETRI
        public Recenzat(string stareCivila, string nationalitate, Locuinta locuinta, IdentitateCulturala identitateCulturala, string cnp, List<string> numeComplet, bool sex, DateTime dataNasterii)
            :base(numeComplet, cnp, dataNasterii,sex)
        {
            this.stareCivila = stareCivila;
            this.nationalitate = nationalitate;
            this.locuinta = new Locuinta();
            this.identitateCulturala = new IdentitateCulturala();
        }


        //PROPRIETATI
        public string StareCivila { get => stareCivila; set => stareCivila = value; }
        public string Nationalitate { get => nationalitate; set => nationalitate = value; }
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
