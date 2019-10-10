using Aplication;
using Domain;
using StructureMap;
using System.Collections.Generic;

namespace StructuredApplication
{
    public class Generator
    {
        public Generator()
        {
            var container = new Container(new PluginFinder());
            generator = container.GetInstance<Aplication.Generator>();
        }

        public Aplication.Generator generator { get; }

        public List<Plan> Generate(List<PlanPattern> plansPatterns)
        {
            return generator.Generate(plansPatterns);
        }
    }
}
