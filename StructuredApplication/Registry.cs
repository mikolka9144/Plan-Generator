using Domain;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructuredApplication
{
    public class PluginFinder:Registry
    {
        public PluginFinder()
        {
            Scan(s =>
            {
                s.AssembliesFromApplicationBaseDirectory();
                s.AddAllTypesOf<IPlanPlugin>();
            });
        }
    }
}
