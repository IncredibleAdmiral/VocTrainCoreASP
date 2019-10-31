using System;
using System.Collections.Generic;

namespace VocTrainerCoreASP.Models
{
    public partial class IrregularVerbsTable
    {
        public int IdWord { get; set; }
        public string PastSimple { get; set; }
        public string PastParticiple { get; set; }

        public WordsTable IdWordNavigation { get; set; }
    }
}
