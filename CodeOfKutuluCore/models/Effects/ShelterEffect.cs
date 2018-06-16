using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOfKutulu
{
    public class ShelterEffect
    {
        public readonly Vec Origin;
        public readonly int RemainingEnergy;

        public ShelterEffect(Vec origin, int remainingEnergy)
        {
            Origin = origin;
            RemainingEnergy = remainingEnergy;
        }
    }
}
