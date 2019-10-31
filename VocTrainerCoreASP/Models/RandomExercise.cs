using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using VocTrainerCoreASP.Interfaces;

namespace VocTrainerCoreASP.Models
{
    public class RandomExercise : IGetTask
    {

        private Random rnd;

        public RandomExercise()
        {
            rnd = new Random();
        }

        private ContextTable RandomContext()
        {
            return GeneralWordAndExamplesRepository.contextualRepository.GetEnteryOnIndex(rnd.Next(0, GeneralWordAndExamplesRepository.contextualRepository.TableCount - 1));
        }

        private ExamplesTable SearchExample(int exampleID)
        {
            return GeneralWordAndExamplesRepository.examplesRepository.GetExampleOnID(exampleID);
        }

        private string DashGenerator(int count)
        {
            string s = "";
            for (int i = 0; i < count + 1; i++)
                s += "_";
            return s;
        }

        private string CutExample(string example, string cutWord)
        {
            return new Regex(@"\b(" + cutWord + @")\b").Replace(example, DashGenerator(cutWord.Count()));
        }

        public Exercise FormationOfTheTask()
        {
            var rCon = RandomContext();
            var rExam = SearchExample(rCon.IdExample);

            return new Exercise { WordID = rCon.IdWord, ExampleID = rCon.IdExample, ExampleTranslate = rExam.ExampleTranslation, CutExample = CutExample(rExam.Example, rCon.WordFormInExample) };
        }

    }
}
