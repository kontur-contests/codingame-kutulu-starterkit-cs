using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOfKutulu
{
    public class LightEffect : Effect
    {
        public LightEffect(Vec origin, int timeLeft, int creatorId) : base(origin, timeLeft, creatorId)
        {
        }
    }
}
