using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAbstractIsAs
{
    abstract class Animal
    {
        private string name;
        private int weight;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
         public abstract string GetSound();
    }
}
