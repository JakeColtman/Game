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
        public ICoordinate<T> get_final_position(Func<Dictionary<T, int>, ICoordinate<T>> constructor)
        {

            Dictionary<T, int> dimensionValues = new Dictionary<T, int>();

            foreach(T dimension in mover.get_pos().get_dimensions())
            {
                int currentVal = mover.get_pos().get_dimension_value(dimension);
                int deltaVal = (int)movement.get_vector_for_dimension(dimension).get_direction() * movement.get_vector_for_dimension(dimension).get_distance();
                dimensionValues.Add(dimension, currentVal + deltaVal);
            }

            return constructor(dimensionValues);
        }

    }
}
