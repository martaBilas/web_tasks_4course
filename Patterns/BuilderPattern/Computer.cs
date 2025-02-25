using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Computer
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }

        public override string ToString()
        {
            return $"Computer with {CPU} CPU, {GPU} GPU, {RAM}GB RAM, and {Storage}GB Storage.";
        }
    }
}
