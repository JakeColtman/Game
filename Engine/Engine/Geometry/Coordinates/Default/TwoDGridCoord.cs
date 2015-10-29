using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Geometry.Coordinates.Default
{
    public class TwoDGridCoord : Coordinate
    {

        int _x;
        int _y;

        public TwoDGridCoord(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int get_x_value()
        {
            return _x;
        }

        public int get_y_value()
        {
            return _y;
        }

    }
}
