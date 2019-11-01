using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VocTrainerCoreASP.Models;
using VocTrainerCoreASP.Interfaces;

namespace VocTrainerCoreASP.Controllers
{
    public class TaskController : Controller
    {
        private readonly IGetTask exercise;
        private readonly IChecksAnswer checks;

        public TaskController(IGetTask exercise, IChecksAnswer check)
        {
            this.exercise = exercise;
            this.checks = check;
        }

        //[HttpGet]
        public ViewResult GetTask()
        {
            var ex = exercise.FormationOfTheTask();
            return View(ex);
        }




        //[HttpPost]
        public ViewResult GetAnswer(int wordID, int exampleID, string answer)
        {
            string cheksResult;
            if (checks.AnswerChecks(wordID, exampleID, answer))
                cheksResult = "Right";
            else cheksResult = "Wrong";
            return View(cheksResult);

        }
    }
}
