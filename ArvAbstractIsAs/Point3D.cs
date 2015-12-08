using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3;

namespace ArvAbstractIsAs
{
    class Point3D : Point
    {
        private int z;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        public Point3D()
        {
            X = 10;
            Y = 1;
            Z = 15;
        }
        public Point3D(int x, int y, int z) : base(x, y)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"X: {X}, Y: {Y}, Z: {Z}";
        }
    }
}
