using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class OfficeComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void BuildCPU() => _computer.CPU = "Intel i5";
        public void BuildGPU() => _computer.GPU = "Integrated Graphics";
        public void BuildRAM() => _computer.RAM = 16;
        public void BuildStorage() => _computer.Storage = 512;
        public Computer GetComputer() => _computer;
    }
}
