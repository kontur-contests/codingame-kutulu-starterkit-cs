using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOfKutulu
{
    public class Explorer : Entity
    {
        public readonly int Sanity;
        public readonly int PlansLeft;
        public readonly int LightsLeft;
        public Explorer(int id, Vec position, int sanity, int plansLeft, int lightsLeft) : base(id, position)
        {
            Sanity = sanity;
            PlansLeft = plansLeft;
            LightsLeft = lightsLeft;
        }
    }
}
