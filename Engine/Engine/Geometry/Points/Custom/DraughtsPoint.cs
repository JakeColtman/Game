using Engine.Geometry.Directions.Custom.Draughts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Geometry.Points.Custom
{
    class DraughtsPoint : IPoint
    {
        
        int _left;
        int _right;

        public DraughtsPoint(int left, int right)
        {
            _left = left;
            _right = right;
        }


        public IPoint get_next_point_in_direction(Direction direction)
        {
            if (direction is WhiteManLeftDirection) return new IsometricPoint(_left + 1, _right);
            if (direction is WhiteManRightDirection) return new IsometricPoint(_left, _right + 1);
            if (direction is BlackManLeftDirection) return new IsometricPoint(_left - 1, _right);
            if (direction is BlackManRightDirection) return new IsometricPoint(_left, _right - 1);

            throw new NotImplementedException(direction.ToString() + " is not a valid dimension");
        }
    }
}
