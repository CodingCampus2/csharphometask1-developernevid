using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task1, string> TaskSolver = task =>
            {
                //Andrii Nevidomyi solution

                //Example
                //[task.City.Name] = "Virtualiev"
                //[task.City.Population] = 1400
                //[task.City.SickPercentage] = 0.3
                //[task.Virus.Name] = "Hlomanda"
                //[task.Virus.KillProbability] = 0.2

                //"There are 420 people sick with Hlomanda in the city of Virtualiev, 84 of which died"

                //------------------------------------------------------------------------------------
                //parse
                float population, sickPersentage, killProbability;

                //result
                float sickPeople = 0, peopleDied = 0;

                try
                {
                    population = Convert.ToSingle(task.City.Population);
                    sickPersentage = Convert.ToSingle(task.City.SickPercentage);
                    killProbability = Convert.ToSingle(task.Virus.KillProbability);

                    sickPeople = population * sickPersentage;
                    peopleDied = sickPeople * killProbability;

                }
                catch (FormatException)
                {
                    Console.WriteLine("FormatException");
                }


                return $"There are {Math.Truncate(sickPeople)} people sick with {task.Virus.Name} in the city of {task.City.Name}, {Math.Truncate(peopleDied)} of which died";
            };

            Task1.CheckSolver(TaskSolver);
        }
    }
}
