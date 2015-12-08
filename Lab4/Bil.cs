using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Bil
    {
        private string marke;
        private int antalVaxlar;
        private string farg;
        private string typ;
        public string Marke
        {
            get { return marke; }
            set { marke = value; }
        }
        public int AntalVaxlar
        {
            get { return antalVaxlar; }
            set { antalVaxlar = value; }
        }
        public string Farg
        {
            get { return farg; }
            set { farg = value; }
        }
        public string Typ
        {
            get { return typ; }
            set {
                if (value.ToLower().Trim() == "kupe" || value == "kombi")
                typ = value; 
            //else throw new Exception ("Not valid type!");
            }
        }
        public Bil()
        {
            Marke = "Audi";
            AntalVaxlar = 5;
            Farg = "Red";
            Typ = "kombi";
        }
        public Bil(string marke, int antalVaxlar, string farg, string typ)
        {
            Marke = marke;
            AntalVaxlar = antalVaxlar;
            Farg = farg;
            Typ = typ;
        }
        public virtual void Drive()
        {
            Console.WriteLine("brum brum");
        }
        public override string ToString()
        {
            return $"Marke: {Marke} Antal vaxlar: {AntalVaxlar} Farg: {Farg} Typ: {Typ}";
        }
    }
}
