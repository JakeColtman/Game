using Engine.Mappings.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Movement
{
    public class MovementRequest<T> : Message
    {
        public IMoveable<T> mover;
        public ICoordinate<T> end;
    }
}
