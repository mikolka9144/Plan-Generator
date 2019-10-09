using Aplication;
using Domain;
using StructureMap;
using System.Collections.Generic;

namespace StructuredApplication
{
    class Generator
    {
        public Generator()
        {
            var container = new Container(new PluginFinder());
            generator = container.GetInstance<BaseGenerator>();
        }

        public BaseGenerator generator { get; }

        public List<Plan> Generate(List<PlanPattern> plansPatterns)
        {
            return generator.Generate(plansPatterns);
        }
    }
}
