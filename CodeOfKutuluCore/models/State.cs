using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOfKutulu
{
    public class State
    {
        public readonly InitData InitData;
        public Cell[,] Map => InitData.Map;
        public int Height => Map.GetLength(0);
        public int Width => Map.GetLength(1);
        public Cell GetAt(Vec position) => Map[position.Y, position.X];
        public readonly Explorer Me;
        public readonly List<Explorer> Others;
        public readonly List<Wanderer> Wanderers;
        public readonly List<Slasher> Slashers;
        public readonly List<PlanEffect> PlanEffects;
        public readonly List<LightEffect> LightEffects;
        public readonly List<YellEffect> YellEffects;
        public readonly List<ShelterEffect> ShelterEffects;

        public State(InitData initData, Explorer me, List<Explorer> others, List<Wanderer> wanderers,
            List<Slasher> slashers, List<PlanEffect> planEffects, List<LightEffect> lightEffects,
            List<YellEffect> yellEffects, List<ShelterEffect> shelterEffects)
        {
            InitData = initData;
            Me = me;
            Others = others;
            Wanderers = wanderers;
            Slashers = slashers;
            PlanEffects = planEffects;
            LightEffects = lightEffects;
            YellEffects = yellEffects;
            ShelterEffects = shelterEffects;
        }
    }
}
