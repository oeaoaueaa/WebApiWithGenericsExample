using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWithGenericsExample.Domain
{
    public class TennisAvailableSources : IAvailableSources
    {
        public TennisAvailableSources(bool isTennisAutomated)
        {
            IsTennisAutomated = isTennisAutomated;
        }

        public bool IsTennisAutomated { get; }
    }
}
