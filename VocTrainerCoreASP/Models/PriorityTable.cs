using System;
using System.Collections.Generic;

namespace VocTrainerCoreASP.Models
{
    public partial class PriorityTable
    {
        public int IdUser { get; set; }
        public int IdWord { get; set; }
        public int Correctly { get; set; }
        public int Uncorrectly { get; set; }

        public UsersTable IdUserNavigation { get; set; }
        public WordsTable IdWordNavigation { get; set; }
    }
}
