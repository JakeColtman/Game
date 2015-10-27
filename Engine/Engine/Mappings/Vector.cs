using Engine.Mappings.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mappings
{
    public interface IVector
    {
        int get_distance();
        Direction get_direction();
    }

    public interface IMovement<T>
    {
        IVector get_vector_for_dimension(T dimension);
    }

    public class Vector : IVector
    {

        int _distance;
        Direction _direction;

        public Vector(int distance, Direction direction)
        {
            _distance = distance;
            _direction = direction;
        }

        public int get_distance()
        {
            return _distance;
        }

        public Direction get_direction()
        {
            return _direction;
        }
    }


    public class Iso2DMovement : IMovement<Iso2D>
    {

        IVector _left;
        IVector _right;

        public Iso2DMovement(IVector left, IVector right)
        {
            _left = left;
            _right = right;
        }
       
        public IVector get_vector_for_dimension(Iso2D dimension)
        {
            switch (dimension)
            {
                case Iso2D.left:
                    return _left;
                default:
                    return _right;
            }
        }
    }

}
