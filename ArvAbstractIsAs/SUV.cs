﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4;

namespace ArvAbstractIsAs
{
    class SUV : Bil
    {
        public override void Drive()
        {
            Console.WriteLine("VROOM VROOM");
        }
    }
}
