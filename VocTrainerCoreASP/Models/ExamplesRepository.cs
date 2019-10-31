using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VocTrainerCoreASP.Models
{
    public class ExamplesRepository : Repository
    {

        List<ExamplesTable> examplesTableList;


        public ExamplesRepository(VocabularyContext context)
        {
            this.context = context;
            RefreshContext();
        }

        public void RefreshContext()
        {
            examplesTableList = context.ExamplesTable.ToList();
            TableCount = examplesTableList.Count();
        }

        public ExamplesTable GetExampleOnID(int exampleID)
        {
            return examplesTableList.Single(x => x.IdExample == exampleID);
        }

    }
}