using System;
using System.Collections.Generic;

namespace VocTrainerCoreASP.Models
{
    public partial class WordsTable
    {
        public WordsTable()
        {
            ContextTable = new HashSet<ContextTable>();
            PriorityTable = new HashSet<PriorityTable>();
        }

        public int IdWord { get; set; }
        public string Word { get; set; }
        public string WordTranslation { get; set; }
        public string PartOfSpeech { get; set; }

        public IrregularVerbsTable IrregularVerbsTable { get; set; }
        public ICollection<ContextTable> ContextTable { get; set; }
        public ICollection<PriorityTable> PriorityTable { get; set; }
    }
}
