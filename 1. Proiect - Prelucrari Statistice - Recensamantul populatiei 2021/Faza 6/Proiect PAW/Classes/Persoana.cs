using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
    public abstract class Persoana
    {

        //DEFINIRE ATRIBUTE
        protected string numeComplet;
        protected DateTime dataNasterii;
        protected string sex;



        //CONSTRUCTOR IMPLICIT
        public Persoana()
        {
            this.numeComplet = " ";
            this.dataNasterii = System.DateTime.Now;
            this.sex = " ";

        }


        //CONSTRUCTOR CU TOTI PARAMETRI
        public Persoana(string numeComplet, DateTime dataNasterii, string sex)
        {
            this.numeComplet = numeComplet;
            this.dataNasterii = dataNasterii;
            this.sex = sex;

        }


        //PROPRIETATI

        public DateTime DataNasterii { get => dataNasterii; set => dataNasterii = value; }
        public string NumeComplet { get => numeComplet; set => numeComplet = value; }
        public string Sex { get => sex; set => sex = value; }





        //TO STRING
        public override string ToString()
        {
            //Afisare pentru lista de nume
            string afisare1 = numeComplet + ", de sex " + sex + ", nascut/a la data de " + dataNasterii;


            return afisare1;

        }


        //METODA ABSTRACTA
        public abstract void calculareVarstaActuala();


    }
}