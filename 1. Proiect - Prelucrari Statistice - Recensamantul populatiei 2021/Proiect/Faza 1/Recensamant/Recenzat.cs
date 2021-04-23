using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recensamant
{
    class Recenzat : Persoana, ICloneable
    {
        private Locuinta locuinta;
        private String stareCivila;

        public Recenzat(Locuinta locuinta, string stareCivila)
        {
            this.locuinta = locuinta;
            this.stareCivila = stareCivila;
        }

        public override string calculareVarstaActuala(DateTime Dob)
        {
            DateTime Now = DateTime.Now;
            int Years = new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1;
            DateTime PastYearDate = Dob.AddYears(Years);
            int Months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (PastYearDate.AddMonths(i) == Now)
                {
                    Months = i;
                    break;
                }
                else if (PastYearDate.AddMonths(i) >= Now)
                {
                    Months = i - 1;
                    break;
                }
            }
            int Days = Now.Subtract(PastYearDate.AddMonths(Months)).Days;
            int Hours = Now.Subtract(PastYearDate).Hours;
            int Minutes = Now.Subtract(PastYearDate).Minutes;
            int Seconds = Now.Subtract(PastYearDate).Seconds;
            return String.Format("Varsta: {0} ani {1} luni {2} zile {3} ore {4} secunde",
            Years, Months, Days, Hours, Seconds);
        }

    

        public object Clone()
        {
            Recenzat clona = (Recenzat)this.MemberwiseClone();
            return clona;

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

  
