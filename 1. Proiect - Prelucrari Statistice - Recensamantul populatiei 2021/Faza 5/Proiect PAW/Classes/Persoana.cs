using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable] 
    public abstract class Persoana {

        //DEFINIRE ATRIBUTE
        protected List<string> numeComplet;
        protected readonly string cnp;
        protected DateTime dataNasterii;
        protected bool esteDeSexFeminin;
     


        //CONSTRUCTOR IMPLICIT
        protected Persoana()
        {
            this.numeComplet = new List<string>();
            this.cnp = "";
            this.dataNasterii = System.DateTime.Now;
            this.esteDeSexFeminin = false;
            
        }

     
        //CONSTRUCTOR CU TOTI PARAMETRI
        protected Persoana(List<string> numeComplet, string cnp, DateTime dataNasterii, bool sex)
        {
            this.numeComplet = new List<string>();
            foreach (string n in numeComplet)
            {
                this.numeComplet.Add(n);
            }
            this.cnp = cnp;
            this.dataNasterii = dataNasterii;
            this.esteDeSexFeminin = sex;
           
        }


        //PROPRIETATI
        public List<string> NumeComplet { get => numeComplet; set => numeComplet = value; }
        public string Cnp { get => cnp; }
        public DateTime DataNasterii { get => dataNasterii; set => dataNasterii = value; }
        public bool EsteDeSexFeminin { get => esteDeSexFeminin; set => esteDeSexFeminin = value; }
       




        //TO STRING
        public override string ToString()
        {
            //Afisare pentru lista de nume
            string afisare1 = "Persoana cu numele ";
            foreach (string s in numeComplet)
            {
                afisare1 += s.ToString();
            }

            string afisare2 = " se identifica cu CNP-ul " + cnp + " si "
                    + " este de sex feminin = " + esteDeSexFeminin
                    + " fiind nascuta la data de " + dataNasterii;


            return afisare1 += afisare2;

        }


        //METODA ABSTRACTA
        public abstract void calculareVarstaActuala();
  
      
    }
}
