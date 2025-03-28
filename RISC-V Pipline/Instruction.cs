﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RISC_V_Pipeline
{

    public class Instruction
    {
        public InstructionType Operand { get; set; }
        public string Source1 { get; set; }
        public string Source2 { get; set; }
        public string Destination { get; set; }
        public string Label { get; set; }
        public bool ImmediateFlag { get; set; }
    }

    public enum InstructionType
    {
        LW, SW, ARITHMETIC, CONTROL
    }

}

