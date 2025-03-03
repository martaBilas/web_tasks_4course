﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IComputerBuilder
    {
        void BuildCPU();
        void BuildGPU();
        void BuildRAM();
        void BuildStorage();
        Computer GetComputer();
    }
}
