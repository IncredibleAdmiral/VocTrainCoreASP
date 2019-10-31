using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VocTrainerCoreASP.Interfaces;

namespace VocTrainerCoreASP.Models
{
    public class Checks : IChecksAnswer
    {

        public bool AnswerChecks(int wordID, int ExampleID, string answer)
        {
            var rightAnswer = GeneralWordAndExamplesRepository.contextualRepository.contextTableList.Single(x => x.IdWord == wordID && x.IdExample == ExampleID).WordFormInExample.ToLower();
            if (rightAnswer == answer.ToLower())
                return true;
            else return false;
        }
    }
}
