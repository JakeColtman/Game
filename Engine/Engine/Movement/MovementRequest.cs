using Engine.Mappings;
using Engine.Mappings.Coordinates;
using Engine.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Movement
{
    public class MovementRequest<T> : Message
    {
        public IEntity<T> mover;
        public IMovement<T> movement;
    }
}
