using Engine.Geometry;
using Engine.Mappings;
using Engine.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Movement
{
    public class MovementRequest : Message
    {
        IEntity _mover;
        IMovement _movement;

        public MovementRequest(IEntity mover, IMovement movement )
        {
            _mover = mover;
            _movement = movement;
        }
              
        public IPoint get_final_position()
        {

            IPoint start = _mover.get_pos();

            foreach(Geometry.Direction direction in _movement.get_directions())
            {
                start = start.get_next_point_in_direction(direction);
            }

            return start;
        }

    }
   
}
