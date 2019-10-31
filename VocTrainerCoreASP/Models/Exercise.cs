using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VocTrainerCoreASP.Models
{
    public class Exercise
    {
        public int WordID { get; set; }
        public int ExampleID { get; set; }
        public string ExampleTranslate { get; set; }
        public string CutExample { get; set; }
    }
}