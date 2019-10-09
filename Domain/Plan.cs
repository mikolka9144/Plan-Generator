using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Plan
    {
        public Plan(Lesson[,] lessonGrid)
        {
            LessonGrid = lessonGrid;
        }

        public Lesson[,] LessonGrid { get; }
    }

    public class PlanPattern
    {
        public PlanPattern(int x,int y,int seed,List<Lesson> lessons)
        {
            X = x;
            Y = y;
            Seed = seed;
            Lessons = lessons;
        }

        public int X { get; }
        public int Y { get; }
        public int Seed { get; }
        public List<Lesson> Lessons { get; }
    }
    public enum Lesson
    {
        Empty = 0,Math,History,Polish,english,PE
    }
}
