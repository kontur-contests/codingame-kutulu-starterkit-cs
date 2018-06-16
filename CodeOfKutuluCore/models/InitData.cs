using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOfKutulu
{
    public class InitData
    {
        public readonly Cell[,] Map;
        public readonly int SanityLossLonely;
        public readonly int SanityLossGroup;
        public readonly int WandererSpawnTime;
        public readonly int WandererLifeTime;
        public InitData(Cell[,] map, int sanityLossLonely, int sanityLossGroup,
            int wandererSpawnTime, int wandererLifeTime)
        {
            Map = map;
        }
    }
}
