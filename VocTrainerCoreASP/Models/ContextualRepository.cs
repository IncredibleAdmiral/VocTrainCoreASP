using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VocTrainerCoreASP.Models
{
    public class ContextualRepository : Repository
    {


        public List<ContextTable> contextTableList;



        public ContextualRepository(VocabularyContext context)
        {
            this.context = context;
            RefreshContext();
        }

        public void RefreshContext()
        {
            if (context != null)
            {
                contextTableList = context.ContextTable.ToList();
                TableCount = contextTableList.Count();
            }
        }

        public ContextTable GetEnteryOnIndex(int i)
        {
            return contextTableList[i];
        }
    }
}