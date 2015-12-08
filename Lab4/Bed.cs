using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Bed
    {
        int pillowNumber;
        string sheetColor;
        bool bedMade;
        public int PillowNumber
        {
            get { return pillowNumber; }
            set
            {
                if (value >= 0)
                    pillowNumber = value;
            }
        }
        public string SheetColor
        {
            get { return sheetColor; }
            set
            {
                if (value != null)
                    sheetColor = value;
            }
        }
        public bool BedMade
        {
            get { return bedMade; }
            set
            {
                if (value == true || value == false)
                    bedMade = value;
            }
        }
        public string FrameMaterial(string material)
        {
            return material;
        }
        public Bed()
        {
            PillowNumber = 2;
            SheetColor = "Beige";
            BedMade = false;
        }
        public Bed(int pillowNumber, bool bedMade) : this()
        {
            PillowNumber = pillowNumber;
            BedMade = bedMade;
        }
        public override string ToString()
        {
            return $"Pillow number: {PillowNumber} Sheet color: {SheetColor} Bed made: {BedMade}";
        }
    }
}
