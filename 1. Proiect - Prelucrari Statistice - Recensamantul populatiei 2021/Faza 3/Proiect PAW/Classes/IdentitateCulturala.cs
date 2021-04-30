using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
   public class IdentitateCulturala
    {
        //DEFINIRE ATRIBUTE
        private String etnie;
        private String religie;
        private String limbaMaterna;
        private bool esteHetero;

        public IdentitateCulturala()
        {
            this.etnie = "Lipoveana";
            this.religie = "Ortodoxa - Rit vechi";
            this.limbaMaterna = "Rusa";
            this.esteHetero = true;
        }


        //CONSTRUCTOR CU PARAMETRI
        public IdentitateCulturala(string etnie, string religie, string limbaMaterna, bool esteHetero)
        {
            this.etnie = etnie;
            this.religie = religie;
            this.limbaMaterna = limbaMaterna;
            this.esteHetero = esteHetero;
        }

        //PROPRIETATI
        public string Etnie { get => etnie; set => etnie = value; }
        public string Religie { get => religie; set => religie = value; }
        public string LimbaMaterna { get => limbaMaterna; set => limbaMaterna = value; }
        public bool EsteHetero { get => esteHetero; set => esteHetero = value; }

        //TO STRING
        public override string ToString()
        {
            return "Persoana este de etnie " + etnie
                + ", avand religia " + religie
                + " si limba materna " + limbaMaterna
                + " si orientarea sexuala dreapta " + esteHetero;
        }
    }
}
