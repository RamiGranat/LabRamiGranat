﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Point
    {
        private int y ;
        private int x ;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public static implicit operator Point3D(Point point)
        {
            return new Point3D(12, 34, 56);
        }
    }
}
