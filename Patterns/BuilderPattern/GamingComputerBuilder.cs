using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void BuildCPU() => _computer.CPU = "Intel i9";
        public void BuildGPU() => _computer.GPU = "NVIDIA RTX 3080";
        public void BuildRAM() => _computer.RAM = 32;
        public void BuildStorage() => _computer.Storage = 1000;
        public Computer GetComputer() => _computer;
    }
}
