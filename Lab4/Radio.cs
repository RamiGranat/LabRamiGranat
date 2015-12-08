using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Radio
    {
        int volume;
        bool on;
        double frequency;
        static int instanceCount;
        public int Volume
        {
            get { return volume; }
            set
            {
                if (value >= 0 && value <= 100)
                    volume = value;
            }
        }
        public bool On
        {
            get { return on; }
            set
            {
                if (value == true || value == false)
                on = value;
            }
        }
        public double Frequency
        {
            get { return frequency; }
            set
            {
                if (value >= 30 && value <= 300)
                    frequency = value;
            }
        }
        public int InstanceCount
            {
            get { return instanceCount; }
            }

        public Radio()
        {
            Volume = 50;
            On = false;
            Frequency = 120;
            instanceCount++;
        }
        public Radio(int volume, double frequency):this()
        {
            Volume = volume;
            On = false;
            Frequency = frequency;
        }
        static Radio()
        {
            instanceCount = 0;
        }
        public override string ToString()
        {
            return $"Volume: {Volume} On: {On} Frequency: {Frequency}kHz Instance count: {InstanceCount}";
        }
    }
}
