using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> initialSchedule = Console.ReadLine()
              .Split(", ", StringSplitOptions.RemoveEmptyEntries)
              .ToList();

            //Add: { lessonTitle} – add the lesson to the end of the schedule, if it does not exist.
            //Insert:{ lessonTitle}:{ index} – insert the lesson to the given index, if it does not exist.
            //Remove:{ lessonTitle} – remove the lesson, if it exists.
            //Swap:{ lessonTitle}:{ lessonTitle} – change the place of the two lessons, if they exist.
  
            //Exercise:{ lessonTitle} – add Exercise in the schedule right after the lesson index, if the lesson exists and there is no exercise already, 
            //in the following format "{lessonTitle}-Exercise".If the lesson doesn`t exist, add the lesson in the end of the course schedule, followed by the Exercise.
            
            //Each time you Swap or Remove a lesson, you should do the same with the Exercises, if there are any, which follow the lessons.
      
            while (true)
            {
                string input = Console.ReadLine();

                if (input=="course start")
                {
                    break;
                }

                string[] modifyCourseSchedule = input.Split(":",StringSplitOptions.RemoveEmptyEntries);


                switch (modifyCourseSchedule[0])
                {
                    case "Add":
                        if (!initialSchedule.Contains(modifyCourseSchedule[1]))
                        {
                            initialSchedule.Add(modifyCourseSchedule[1]);
                        }
                        break;
                    
                    case "Insert":
                        if (!initialSchedule.Contains(modifyCourseSchedule[1]))
                        {
                            initialSchedule.Insert(int.Parse(modifyCourseSchedule[2]),modifyCourseSchedule[1]);
                        }
                        break;
                    
                    case "Remove":
                       
                        if (initialSchedule.Contains(modifyCourseSchedule[1]))
                        {
                            initialSchedule.Remove(modifyCourseSchedule[1]);
                        }

                        if (initialSchedule.Contains(modifyCourseSchedule[1]+"-Exercise"))
                        {
                            initialSchedule.Remove(modifyCourseSchedule[1]+"-Exercise");
                        }
                        break;

                    case "Swap":

                        int lessonOneIdx = initialSchedule.IndexOf(modifyCourseSchedule[1]);
                        int lessonOneIdxExc = initialSchedule.IndexOf(modifyCourseSchedule[1]+"-Exercise");
                        int lessonTwoIdx = initialSchedule.IndexOf(modifyCourseSchedule[2]);
                        int lessonTwoIdxExc = initialSchedule.IndexOf(modifyCourseSchedule[2]+"-Exercise");
                        
                        if (initialSchedule.Contains(modifyCourseSchedule[1])
                            &&
                            initialSchedule.Contains(modifyCourseSchedule[2]))
                        {
                            initialSchedule.RemoveAt(lessonOneIdx);
                            initialSchedule.Insert(lessonOneIdx, modifyCourseSchedule[2]);
                            if (lessonOneIdxExc>0)
                            {
                                initialSchedule.RemoveAt(lessonOneIdxExc);
                                initialSchedule.Insert(lessonTwoIdx+1, modifyCourseSchedule[1]+"-Exercise");
                            }
                            
                            initialSchedule.RemoveAt(lessonTwoIdx);
                            initialSchedule.Insert(lessonTwoIdx, modifyCourseSchedule[1]);
                            if (lessonTwoIdxExc > 0)
                            {
                                initialSchedule.RemoveAt(lessonTwoIdxExc);
                                initialSchedule.Insert(lessonOneIdx+1, modifyCourseSchedule[2]+"-Exercise");
                            }
                            
                        }
                        break;

                    case "Exercise":
                        int idx = initialSchedule.IndexOf(modifyCourseSchedule[1]);
                        
                        if (!initialSchedule.Contains(modifyCourseSchedule[1]))
                        {
                            initialSchedule.Add(modifyCourseSchedule[1]);
                            initialSchedule.Add(modifyCourseSchedule[1]+"-Exercise");
                        }
                        else
                        {
                            initialSchedule.Insert((idx+1), (modifyCourseSchedule[1] + "-Exercise"));
                            
                        }
                        break;

                    default:
                        break;
                }
                
              

            }

            for (int i = 1; i <=initialSchedule.Count; i++)
            {
                Console.WriteLine($"{i}.{initialSchedule[i-1]}");
            }

               

                
            
            
        }
    }
}
