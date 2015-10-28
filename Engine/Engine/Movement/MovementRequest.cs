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
    public class Iso2DMovementRequest : Message
    {
        public IEntity<Iso2D> mover;
        public IMovement<Iso2D> movement;
        public ICoordinate<Iso2D> get_final_position()
        {

            int currentLeft = mover.get_pos().get_dimension_value(Iso2D.left);
            int currentRight = mover.get_pos().get_dimension_value(Iso2D.right);

            int deltaLeft = (int)movement.get_vector_for_dimension(Iso2D.left).get_direction() * movement.get_vector_for_dimension(Iso2D.left).get_distance();
            int deltaRight = (int)movement.get_vector_for_dimension(Iso2D.right).get_direction() * movement.get_vector_for_dimension(Iso2D.right).get_distance();

            return new Iso2DCoord(currentLeft + deltaLeft, currentRight + deltaRight);
        }

    }
}
