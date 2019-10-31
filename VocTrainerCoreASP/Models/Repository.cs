using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VocTrainerCoreASP.Models
{
    public abstract class Repository
    {
        protected VocabularyContext context;

        public int TableCount { get; protected set; }


    }
}