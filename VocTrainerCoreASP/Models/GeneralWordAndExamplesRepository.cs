using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VocTrainerCoreASP.Models
{
    static public class GeneralWordAndExamplesRepository
    {
        static VocabularyContext context;
        public static WordRepository wordRepository { get; private set; }
        public static ContextualRepository contextualRepository { get; private set; }
        public static ExamplesRepository examplesRepository { get; private set; }


        static public void InitializationObjects()
        {
            context = new VocabularyContext();
            wordRepository = new WordRepository(context);
            contextualRepository = new ContextualRepository(context);
            examplesRepository = new ExamplesRepository(context);

        }

        static public void RefreshGeneralRepository()
        {
            wordRepository.RefreshContext();
            contextualRepository.RefreshContext();
            examplesRepository.RefreshContext();
        }

    }
}