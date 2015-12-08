using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Chair
    {
        private Legs legNumber;
        private string padColor;
        public Legs GetLegs() { return legNumber; }
        public void SetLegs(Legs legs)
        {
            legNumber = legs;
        }
        public string GetPadColor() { return padColor; }
        public void SetPadColor(string padColor)
        {
            this.padColor = padColor;
        }
    }
}
