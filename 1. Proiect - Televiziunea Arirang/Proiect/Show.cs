using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class Show:ICloneable,IComparable
    {
        private string denumire;
        private float rating;
        private double venituri;
        private double 
        private string categorieVarsta;

        protected string Denumire { get => denumire; set => denumire = value; }
        protected string CategorieVarsta { get => categorieVarsta; set => categorieVarsta = value; }
        public float Rating { get => rating; set => rating = value; }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
