using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Classes
{
    public class Familie
    {
        //DEFINIRE ATRIBUTE
        private List<Persoana> persoaneFamilie;
        private int nrPersoane;

        //CONSTRUCTOR FARA PARAMETRI
        public Familie(List<Persoana> persoaneFamilie, int nrPersoane)
        {
            this.persoaneFamilie = new List<Persoana>();
            foreach(Persoana p in persoaneFamilie)
            {
                this.persoaneFamilie.Add(p);
            }
            this.nrPersoane = nrPersoane;
        }


        
    }
}
