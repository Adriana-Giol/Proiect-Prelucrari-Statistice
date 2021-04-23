using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recensamant
{
    public abstract class Persoana
    {
        protected String nume;
        protected String prenume;
        protected String CNP;
        protected char sex;
        protected DateTime dataNastere;

        protected Persoana()
        {
            this.nume = "Anonim";
            this.prenume = "Necunoscut";
            this.CNP = "";
            this.sex = 'F';
            this.dataNastere = DateTime.Today;

        }

        protected Persoana(string nume, string prenume, string CNP, char sex, DateTime dataNastere)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.CNP = CNP;
            this.sex = sex;
            this.dataNastere = dataNastere;
        }

      
        public override string ToString()
        {
            return "Persoana " + nume + prenume + " care are CNP-ul " + CNP + " este de sex " + sex + " si este nascuta pe data de " + dataNastere;
        }

        public abstract string calculareVarstaActuala(DateTime Dob);
    }


}
