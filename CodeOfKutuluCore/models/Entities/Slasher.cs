using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOfKutulu
{
    public class Slasher : Entity
    {
        public enum State
        {
            Spawning,
            Wandering,
            Stalking,
            Rushing,
            Stunned
        }

        public readonly int StateChangeTimeout;
        public readonly State CurrentState;
        public readonly int TargetId;

        public Slasher(int id, Vec position, int stateChangeTimeout,
            State currentState, int targetId) : base(id, position)
        {
            StateChangeTimeout = stateChangeTimeout;
            CurrentState = currentState;
            TargetId = targetId;
        }
    }
}
