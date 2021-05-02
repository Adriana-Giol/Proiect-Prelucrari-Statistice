using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Classes
{
    public class Recenzor : Persoana, IComparable, ICloneable
    {
        private int nrMape;
        private int[] coduriMape;
        private String judetRecenzat;
        private String regiuneRecenzata;
        private String localitateRecenzata;


        //CONSTRUCTOR FARA PARAMETRI
        public Recenzor() : base()
        {
            this.coduriMape = new int[] { 23, 24, 25, 26, 27 };
            this.regiuneRecenzata = "Muntenia";
            this.localitateRecenzata = "Braila";
            this.judetRecenzat = "Braila";

        }

        //CONSTRUCTOR CU PARAMETRI
        public Recenzor(List<string> numeComplet, string cnp, int nrMape, string zonaRecenzata, string judetRecenzat,/*[] coduriMape,*/ string localitateRecenzata,  bool sex, DateTime dataNasterii)
            : base(cnp, numeComplet,sex)
        {
            this.nrMape = nrMape;
            /*this.coduriMape = new int[coduriMape.Length];
            for (int i = 0; i < coduriMape.Length; i++)
            {
                this.coduriMape[i] = coduriMape[i];
            }*/
            this.regiuneRecenzata = zonaRecenzata;
            this.localitateRecenzata = localitateRecenzata;
            this.judetRecenzat = judetRecenzat;


        }

        //PROPRIETATI
        public int NrMape { get => nrMape; set => nrMape = value; }
        public string ZonaRecenzata { get => regiuneRecenzata; set => regiuneRecenzata = value; }
        public string LocalitateRecenzata { get => localitateRecenzata; set => localitateRecenzata = value; }
        public string JudetRecenzat { get => judetRecenzat; set => judetRecenzat = value; }
        public int[] CoduriMape { get => coduriMape; set => coduriMape = value; }


        //TO STRING
        public override string ToString()
        {
            string afisare1 = ".Persoana se ocupa de recenzarea zonei " + regiuneRecenzata
                 + " din localitatea" + localitateRecenzata + ", judetul " + judetRecenzat;

            if (coduriMape != null)
            {
                afisare1 += " si a realizat recezarile mapelor cu codurile ";
                for (int i = 0; i < coduriMape.Length; i++)
                    afisare1 += coduriMape + Environment.NewLine;
            }
            else
            {
                afisare1 += ". Recenzorul nu a realizat nici o recenzare.";
            }
            return base.ToString() + afisare1;
        }


        public override void calculareVarstaActuala()
        {
            throw new NotImplementedException();
        }


        public int CompareTo(object obj)
        {
            Recenzor r = (Recenzor)obj;

            string localitateRecenzata1 = this.localitateRecenzata;
            string localitateRecenzata2 = r.localitateRecenzata;

            if (localitateRecenzata1.Equals(localitateRecenzata2, StringComparison.OrdinalIgnoreCase))
            {
                return 1; //true
            }
            else
            {
                return -1;//false;
            }

        }

        //ICLONABLE
        public object Clone()
        {

            //PENTRU VECTOR
            Recenzor clona = (Recenzor)this.MemberwiseClone();
            int[] coduriMapeNoi = (int[])coduriMape.Clone();
            clona.coduriMape = coduriMapeNoi;
            return clona;

        }
        /*
        //OPERATOR + 
        public static Persoana operator +(Persoana p, float salariuNou)
        {
            float[] salariiNoi = new float[p.salariileAnului.Length + 1];
            for (int i = 0; i < p.salariileAnului.Length; i++)
                salariiNoi[i] = p.salariileAnului[i];
            salariiNoi[salariiNoi.Length - 1] = salariuNou;
            p.salariileAnului = salariiNoi;
            return p;
        }
        //Operator + comutativ
        public static Persoana operator +(float salariuNou, Persoana p)
        {
            return p + salariuNou;
        }


        //OPERATOR INDEX  - VECTOR
        public float this[int index]
        {
            get
            {
                if (salariileAnului != null && index >= 0 && index < salariileAnului.Length)
                    return salariileAnului[index];
                else
                    return 0;
            }
            set
            {
                if (value > 0 && index >= 0 && index < salariileAnului.Length)
                    salariileAnului[index] = value;
            }
        }*/

    }

}
