using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Cykel
    {
        string marke;
        int antalVaxlar;
        string typ;
        static int bmwCount;
        public string Marke
        {
            get { return marke; }
            set
            {
                if (value == "BMW")
                    marke = value;
            }
        }
        public int AntalVaxlar
        {
            get { return antalVaxlar; }
            set
            {
                if (value >= 1 && value <= 20)
                    antalVaxlar = value;
            }
        }
        public string Typ
        {
            get { return typ; }
            set
            {
                if (value == "enhjuling" || value == "tvahjuling" || value == "trehjuling")
                    typ = value;
            }
        }
        public int BMWCount
        {
            get { return bmwCount; }
        }
        public Cykel()
        {
            Marke = "BMW";
            AntalVaxlar = 15;
            Typ = "tvahjuling";
        }
        public Cykel(string marke, int antalVaxlar, string typ)
        {
            Marke = marke;
            AntalVaxlar = antalVaxlar;
            Typ = typ;
            if (Typ == "BMW")
                bmwCount++;
        }
        public int ChangeGears(int vaxel)
        {
            if (vaxel >= 0 && vaxel <= antalVaxlar)
                return vaxel;
            else return int.Parse("Inte en vaxel.");
        }
        public override string ToString()
        {
            return $"Marke: {Marke} Antal vaxlar: {AntalVaxlar} Typ: {Typ}";
        }
    }
}
