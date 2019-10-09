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

    public enum Lesson
    {
        Empty = 0,Math,History,Polish,english,PE
    }
}
