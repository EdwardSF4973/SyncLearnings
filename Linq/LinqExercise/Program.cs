using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //You can get the trainee details from the GetTraineeDetails() method in TraineeData class

            TraineeData traineeData = new TraineeData();
            List<TraineeDetails> trainees = traineeData.GetTraineeDetails();

            while (true)
            {
                Console.WriteLine("Enter Menu Number");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            //1 to show trainee ID
                            var traineeID = trainees.Select(train => train.TraineeId);
                            foreach (var t in traineeID)
                            {
                                System.Console.WriteLine($"ID : {t}");
                            }
                            break;
                        }
                    case 2:
                        {
                            //first three ids
                            var firstThree = trainees.Take(3).Select(train => train.TraineeId);
                            foreach (var t in firstThree)
                            {
                                System.Console.WriteLine($"ID : {t}");
                            }
                            break;
                        }
                    case 3:
                        {
                            //last two trainee Id 
                            var lastTwo = trainees.Skip(Math.Max(0, trainees.Count - 2)).Select(train => train.TraineeId);
                            foreach (var t in lastTwo)
                            {
                                System.Console.WriteLine($"Trainee ID : {t}");
                            }
                            break;
                        }
                    case 4:
                        {
                            //count of trainees
                            var traineesCount = trainees.Count;
                            System.Console.WriteLine($"No Of Trainees : {traineesCount}");
                            break;
                        }
                    case 5:
                        {
                            //trainees name passed in 2019 or later
                            var traineesPass = trainees.Where(train => train.YearPassedOut >= 2019).Select(train => train.TraineeName);
                            foreach (var name in traineesPass)
                            {
                                System.Console.WriteLine($"Trainee Name : {name}");
                            }
                            break;
                        }
                    case 6:
                        {
                            //trainee id and name in alphabetic order
                            var traineeOrder = trainees.OrderBy(train => train.TraineeName).Select(train => new { train.TraineeId, train.TraineeName });
                            System.Console.WriteLine("Trainees Name by order");
                            foreach (var line in traineeOrder)
                            {
                                System.Console.WriteLine($"ID : {line.TraineeId}  Name : {line.TraineeName}");
                            }
                            break;
                        }
                    case 7:
                        {
                            //trainee id, name,topicm excersinema and mark who scores more than or equal to 4
                            var topTrainees = trainees.SelectMany(train => train.ScoreDetails.Where(stud => stud.Mark > 4), (train, stud) => new { train.TraineeId, train.TraineeName, stud.TopicName, stud.ExerciseName, stud.Mark });
                            System.Console.WriteLine("Trainee Date");
                            foreach (var data in topTrainees)
                            {
                                System.Console.WriteLine($"{data.TraineeId}  {data.TraineeName}  {data.TopicName}  {data.ExerciseName}  {data.Mark}");
                            }
                            break;
                        }
                    case 8:
                        {
                            //unique passed out years
                            var uniqueYears = trainees.Select(train => train.YearPassedOut).Distinct();
                            foreach (var year in uniqueYears)
                            {
                                System.Console.WriteLine(year);
                            }
                            break;
                        }
                    case 9:
                        {
                            //total mark of single trainee
                            System.Console.WriteLine("Enter the Trainee ID to get marks");
                            string traineeID = Console.ReadLine().ToUpper();

                            var singleTrainee = trainees.FirstOrDefault(train => train.TraineeId == traineeID);

                            if (traineeID != null)
                            {
                                var totalMarks = singleTrainee.ScoreDetails.Sum(stu => stu.Mark);
                                System.Console.WriteLine($"Total Marks of {traineeID} --- {totalMarks}");
                            }
                            else
                            {
                                System.Console.WriteLine("Invalid userID");
                            }
                            break;
                        }
                    case 10:
                        {
                            //first trainee id and his name
                            var firstPerson = trainees.FirstOrDefault();
                            if (firstPerson != null)
                            {
                                System.Console.WriteLine($"First Trainee NAme : {firstPerson.TraineeName}  ID : {firstPerson.TraineeId}");
                            }
                            break;
                        }
                    case 11:
                        {
                            //last trainee details
                            var lastPerson = trainees.LastOrDefault();
                            if (lastPerson != null)
                            {
                                System.Console.WriteLine($"Last Trainee Name : {lastPerson.TraineeName}  ID : {lastPerson.TraineeId}");
                            }
                            break;
                        }

                    case 12:
                        {
                            //total score of each trainee
                            var traineeTotalScore = trainees.Select(train => new
                            {
                                train.TraineeId,
                                train.TraineeName,
                                TotalMark = train.ScoreDetails.Sum(stu => stu.Mark)
                            });
                            System.Console.WriteLine("Trainees with their marks");
                            foreach (var data in traineeTotalScore)
                            {
                                System.Console.WriteLine($"{data.TraineeId}  {data.TraineeName}  {data.TotalMark}");
                            }
                            break;
                        }

                    case 13:
                        {
                            //to show the maximum total mark
                            var max = trainees.Max(train => train.ScoreDetails.Sum(sub => sub.Mark));
                            System.Console.WriteLine("Maximum Marks " + max);
                            break;
                        }

                    case 14:
                        {
                            //to show the minimum total mark
                            var min = trainees.Min(train => train.ScoreDetails.Sum(sub => sub.Mark));
                            System.Console.WriteLine("Minimum Marks " + min);
                            break;
                        }

                    case 15:
                        {
                            //to show avg mark
                            var avg = trainees.Average(train => train.ScoreDetails.Sum(sub => sub.Mark));
                            System.Console.WriteLine("Average Marks " + avg);
                            break;
                        }

                    case 16:
                        {
                            //show true or false if any had more than 40
                            bool anyOne = trainees.Any(train =>train.ScoreDetails.Sum(sub => sub.Mark)>40);
                            System.Console.WriteLine(anyOne);
                            break;
                        }

                    case 17:
                        {
                            //true or fale more than 20 by using all
                            bool isanyOne = trainees.All(train =>train.ScoreDetails.Sum(sub => sub.Mark)>20);
                            System.Console.WriteLine(isanyOne);
                            break;
                        }


                    case 18:
                        {
                            //traineed in descending order
                            var SortedName = trainees.SelectMany( train => train.ScoreDetails,(train,sub)=> new{train.TraineeId,train.TraineeName,sub.TopicName,sub.ExerciseName,sub.Mark})
                            .OrderByDescending(train => train.TraineeName).ThenByDescending(total => total.Mark);

                            foreach(var data in SortedName)
                            {
                                System.Console.WriteLine($" {data.TraineeId}  {data.TraineeName}  {data.TopicName}  {data.ExerciseName}  {data.Mark}");
                            }
                            break;
                        }



                    case 19:
                        {
                            return;
                        }
                    default :
                    {
                        System.Console.WriteLine("Invalid Input");
                        break;
                    }







                }

            }



        }
    }
}
