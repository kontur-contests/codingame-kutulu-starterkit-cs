using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOfKutulu
{
    public class Wanderer : Entity
    {
        public enum State
        {
            Spawning,
            Wandering
        }

        public readonly int LifeTime;
        public readonly State CurrentState;
        public readonly int TargetId;
        public Wanderer(int id, Vec position, int lifeTime,
            State currentState, int targetId) : base(id, position)
        {
            LifeTime = lifeTime;
            CurrentState = currentState;
            TargetId = targetId;
        }
    }
}
