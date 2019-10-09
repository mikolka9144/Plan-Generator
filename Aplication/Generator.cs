using Domain;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Aplication
{
    public class BaseGenerator
    {
        public BaseGenerator(IPlanPlugin[] plugins)
        {
            Plugins = plugins;
        }

        public IPlanPlugin[] Plugins { get; }

        public List<Plan> Generate(List<PlanPattern> plansPatterns)
        {
            var plans = new List<Plan>();
            foreach (var planPattern in plansPatterns)
            {
                plans.Add(new Plan(GetGrid(planPattern.Lessons, planPattern.Y, planPattern.X, planPattern.Seed)));
            }
            return plans;
        }

        private Lesson[,] GetGrid(List<Lesson> lessons,int height,int with,int seed)
        {
            var grid = new Lesson[with, height];
            var randomizer = new Random(seed);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < with; x++)
                {
                    int pos;
                    int probe = 1;
                    do
                    {
                        pos = randomizer.Next(0, lessons.Count - 1);
                        if (Plugins.All(s =>
                                            s.IsLessonPlaceValid(new Plan(grid), (x, y), (with, height), lessons[pos])))
                        {
                            break;
                        }
                        else
                        {
                            if (probe == 3) 
                            {
                                lessons.Add(Lesson.Empty);
                                pos = lessons.Count - 1;
                                break; 
                            };
                            probe++;
                        }

                    } while (true);
                    grid[x, y] = lessons[pos];
                    lessons.RemoveAt(pos);
                    if (lessons.Count == 0) return grid;
                }                 
            }
            return grid;
        }
    }
}
