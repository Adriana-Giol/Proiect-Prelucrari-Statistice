using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public abstract class Persoana: ICloneable, IComparable
    {

        //DEFINIRE ATRIBUTE
        private readonly String cnp;
        private List<String> numeComplet;
        private bool esteDeSexFeminin;
        private DateTime dataNasterii;


        //CONSTRUCTOR IMPLICIT
        protected Persoana()
        {
            this.cnp = "2980505090063";
            this.numeComplet = new List<string>(new string[] { "Giol ", "Adriana" });
            this.esteDeSexFeminin = true;
            this.dataNasterii = System.DateTime.Now;
        }


        //CONSTRUCTOR CU PARAMETRI
        protected Persoana(string cnp, List<string> numeComplet, bool sex, DateTime dataNasterii)
        {
            this.cnp = cnp;
            this.numeComplet = new List<string>();
            foreach (String n in numeComplet)
            {
                this.numeComplet.Add(n);
            }
            this.esteDeSexFeminin = sex;
            this.dataNasterii = dataNasterii;
        }

        //PROPRIETATI
        public string Cnp { get => cnp; }
        public List<string> NumeComplet { get => numeComplet; set => numeComplet = value; }
        public bool EsteDeSexFeminin { get => esteDeSexFeminin; set => esteDeSexFeminin = value; }
        public DateTime DataNasterii { get => dataNasterii; set => dataNasterii = value; }




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

     

        //OPERATOR INDEX - LISTA DE STRING
        public String this[int index]
        {
            get
            {
                if (index >= 0 && index < numeComplet.Count && numeComplet != null)
                    return numeComplet[index];
                else
                    return null;
            }

        }

        //ICLONABLE
        public object Clone()
        {
            //PENTRU LIST

            Persoana clona = (Persoana)this.MemberwiseClone();
            List<string> numeNou = new List<string>();
            foreach (string s in numeComplet)
                numeNou.Add((string)s.Clone());
            clona.numeComplet = numeNou;
            return clona;
        }

        public int CompareTo(object obj)
        {
            Persoana p = (Persoana)obj;
            return DataNasterii.CompareTo(obj);
        }
    }
}
