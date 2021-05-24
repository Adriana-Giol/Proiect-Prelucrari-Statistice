using Proiect_PAW.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Locuinta
    {
        //DEFINIRE ATRIBUTE
        private int nrCamereDeLocuit;
        private int[] suprafeteCamere;
        private int suprafataLocuinta;
        private int anConstructie;
        private String tipConstructie;
        private String tipOcupant;
        private bool esteMediuRural;
        private Adresa adresa;
       

        //CONSTRUCTOR FARA PARAMETRI
        public Locuinta()
        {
            this.nrCamereDeLocuit = 1;
            this.suprafeteCamere = new int[] { 20, 30, 25 };
            this.suprafataLocuinta = 450;
            this.anConstructie = 1950;
            this.tipConstructie = "Casa";
            this.tipOcupant = "Proprietar";
            this.esteMediuRural = false;
            this.adresa = adresa;
          

        }


        //CONSTRUCTOR CU PARAMETRI
        public Locuinta(int nrCamereDeLocuit, int[] suprafeteCamere, int suprafataLocuinta, int anConstructie, string tipConstructie, string tipOcupant, bool esteMediuRural, Adresa adresa, List<Familie> familiiLocuinta)
        {
            this.nrCamereDeLocuit = nrCamereDeLocuit;
            this.suprafeteCamere = new int[suprafeteCamere.Length];
            for (int i = 0; i < suprafeteCamere.Length; i++)
            {
                this.suprafeteCamere[i] = suprafeteCamere[i];
            }
            this.suprafataLocuinta = suprafataLocuinta;
            this.anConstructie = anConstructie;
            this.tipConstructie = tipConstructie;
            this.tipOcupant = tipOcupant;
            this.esteMediuRural = esteMediuRural;
            this.adresa = adresa;
         
        }

        //PROPRIETATI
        public int NrCamereDeLocuit { get => nrCamereDeLocuit; set => nrCamereDeLocuit = value; }
        public int[] SuprafeteCamere { get => suprafeteCamere; set => suprafeteCamere = value; }
        public int SuprafataLocuinta { get => suprafataLocuinta; set => suprafataLocuinta = value; }
        public int AnConstructie { get => anConstructie; set => anConstructie = value; }
        public string TipConstructie { get => tipConstructie; set => tipConstructie = value; }
        public string TipOcupant { get => tipOcupant; set => tipOcupant = value; }
        public bool EsteMediuRural { get => esteMediuRural; set => esteMediuRural = value; }
        public Adresa Adresa { get => adresa; set => adresa = value; }
      


        //TO STRING
        public override string ToString()
        {
            return "Lcuinta dispune de un numar total de " + nrCamereDeLocuit + " camere de locuit "
                + " cu urmatoarele su";
        }
    }
}
