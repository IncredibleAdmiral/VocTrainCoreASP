using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VocTrainerCoreASP.Interfaces
{
    public interface IChecksAnswer
    {
        bool AnswerChecks(int wordID, int ExampleID, string answer);

    }
}