using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace VocTrainerCoreASP.Models
{
    public class WordRepository : Repository
    {

        List<WordsTable> wordList;

        public WordRepository(VocabularyContext context)
        {
            this.context = context;
            RefreshContext();
        }


        public void RefreshContext()
        {
            wordList = context.WordsTable.ToList();
            TableCount = wordList.Count();
        }

        public WordsTable GetTableEntery(int index)
        {
            if (wordList != null && index < TableCount && index >= 0)
                return wordList[index];
            else throw new Exception("Failure");
        }


    }
}
