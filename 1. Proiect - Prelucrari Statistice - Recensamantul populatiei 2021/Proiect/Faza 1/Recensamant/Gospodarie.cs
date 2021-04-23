using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recensamant
{
    class Gospodarie
    {
        private int codMapa;
        private int nrPersoane;
        List<Persoana> listaPersoana = new List<Persoana>();


        public Gospodarie(int codMapa, int nrPersoane, List<Persoana> listaPersoana)
        {
            this.codMapa = codMapa;
            this.nrPersoane = nrPersoane;
            this.listaPersoana = listaPersoana;
        }

        public int CodMapa { get => codMapa; set => codMapa = value; }
        public int NrPersoane { get => nrPersoane; set => nrPersoane = value; }

 
    }
}
