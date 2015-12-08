using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Table
    {
        private Legs legNumber;
        private string tabletopMaterial;
        public Legs GetLegs() { return legNumber; }
        public void SetLegs(Legs legs)
        {
            legNumber = legs;
        }
        public string GetMaterial() { return tabletopMaterial; }
        public void SetMaterial(string material)
        {
            this.tabletopMaterial = material;
        }
    }
}
