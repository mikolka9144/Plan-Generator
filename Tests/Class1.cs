using Aplication;
using Domain;
using System;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class Class1
    {
        [Fact]
        void Generate_GiveemptylistOfLessons_ThrowExeption()
        {
            var generator = new Generator();

            Action action = () => generator.Generate(new List<Lesson>());

            Assert.Throws<Exception>(action);
        }
    }
}
