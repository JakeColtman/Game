using Engine.Geometry.Directions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Geometry
{
    class TwoDSquareGridPoint : IPoint
    {

        int _x;
        int _y;

        public TwoDSquareGridPoint(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public IPoint get_next_point_in_direction(Direction direction)
        {
            if (direction is Left) return new TwoDSquareGridPoint(_x - 1, _y);
            if (direction is Right) return new TwoDSquareGridPoint(_x + 1, _y);
            if (direction is Up) return new TwoDSquareGridPoint(_x, _y + 1);
            if (direction is Down) return new TwoDSquareGridPoint(_x , _y - 1);

            throw new NotImplementedException(direction.ToString() + " is not a valid dimension");
        }
    }
}
