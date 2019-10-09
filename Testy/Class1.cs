using Aplication;
using Domain;
using System;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void Generate_GiveemptylistOfLessons_ThrowExeption()
        {
            var generator = new BaseGenerator();

            Action action = () => generator.Generate(new List<PlanPattern>() { new PlanPattern(3, 3, 123, new List<Lesson>()) });

            Assert.Throws<ArgumentOutOfRangeException>(action);
        }

        [Fact]
        public void Generate_GivelistOfLessons_GeneratePlan()
        {
            var generator = new BaseGenerator();

            var plan = generator.Generate(new List<PlanPattern>(){new PlanPattern(3,3,123,new List<Lesson>()
            { Lesson.Math,Lesson.Polish,Lesson.History,Lesson.english
              ,Lesson.Math

            })});

        }
    }
}
