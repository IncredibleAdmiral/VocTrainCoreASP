using System;
using System.Collections.Generic;

namespace VocTrainerCoreASP.Models
{
    public partial class ContextTable
    {
        public int IdWord { get; set; }
        public int IdExample { get; set; }
        public string ContextualTranslation { get; set; }
        public string WordFormInExample { get; set; }

        public ExamplesTable IdExampleNavigation { get; set; }
        public WordsTable IdWordNavigation { get; set; }
    }
}
