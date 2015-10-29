using Engine.Geometry.Directions;
using Engine.Geometry.Directions.Default;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Geometry
{
    class IsometricPoint : IPoint
    {

        int _left;
        int _right;

        public IsometricPoint(int left, int right)
        {
            _left = left;
            _right = right;
        }
        
        public IPoint get_next_point_in_direction(Direction direction)
        {
            if (direction is UpLeft) return new IsometricPoint(_left + 1, _right);
            if (direction is UpRight) return new IsometricPoint(_left , _right + 1);
            if (direction is DownLeft) return new IsometricPoint(_left - 1, _right);
            if (direction is DownRight) return new IsometricPoint(_left, _right - 1);

            throw new NotImplementedException(direction.ToString() + " is not a valid dimension");
        }
    }
}
