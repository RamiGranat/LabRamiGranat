using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Circle
    {
        private double diameter;
        private Point center;

        public double GetDiameter() { return diameter; }
        public void SetDiameter(double diameter)
        {
            this.diameter = diameter;
        }
        public double GetCircumference() { return diameter*Math.PI; }
        public Point GetCenter() { return center; }
        public void SetCenter(Point p)
        {
            center = p;
        }
    }
}
