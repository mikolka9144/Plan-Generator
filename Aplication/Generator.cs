using Domain;
using System;
using System.Collections.Generic;

namespace Aplication
{
    public class Generator
    {
        public Plan Generate(List<Lesson> lessons)
        {
            return new Plan(GetGrid(lessons, 3, 3, 2323));
        }

        private Lesson[,] GetGrid(List<Lesson> lessons,int height,int with,int seed)
        {
            var grid = new Lesson[with, height];
            var randomizer = new Random(seed);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < with; x++)
                {
                    var pos = randomizer.Next(0, lessons.Count - 1);
                    grid[x, y] = lessons[pos];
                    lessons.RemoveAt(pos);
                    if (lessons.Count == 0) return grid;
                }
            }
            return grid;
        }
    }
}
