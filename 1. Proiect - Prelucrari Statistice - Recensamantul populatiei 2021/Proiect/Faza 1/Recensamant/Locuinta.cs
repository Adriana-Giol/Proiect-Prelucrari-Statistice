using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recensamant
{
    class Locuinta
    {
        private Adresa adresa;
        private int nrCamereDeLocuit;
        private float[] suprafeteCamere;
        private int anConstructie;
        private String tipLocuinta;
        List<Gospodarie> listaGosp = new List<Gospodarie>();

        public Locuinta()
        {

        }

        public Locuinta(Adresa adresa, int nrCamereDeLocuit, float[] suprafeteCamere, int anConstructie, string tipLocuinta, List<Gospodarie> listaGosp)
        {
            this.adresa = adresa;
            this.nrCamereDeLocuit = nrCamereDeLocuit;
            this.suprafeteCamere = suprafeteCamere;
            this.anConstructie = anConstructie;
            this.tipLocuinta = tipLocuinta;
            this.listaGosp = listaGosp;
        }

        public int NrCamereDeLocuit { get => nrCamereDeLocuit; set => nrCamereDeLocuit = value; }
        public float[] SuprafeteCamere { get => suprafeteCamere; set => suprafeteCamere = value; }
        public int AnConstructie { get => anConstructie; set => anConstructie = value; }
        public string TipLocuinta { get => tipLocuinta; set => tipLocuinta = value; }
        internal Adresa Adresa { get => adresa; set => adresa = value; }
    }

}
