using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOfKutulu
{
    public abstract class Entity
    {
        public readonly int Id;
        public readonly Vec Position;

        public Entity(int id, Vec position)
        {
            Id = id;
            Position = position;
        }
    }
}
