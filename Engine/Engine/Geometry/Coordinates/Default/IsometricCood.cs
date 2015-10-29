using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Geometry.Coordinates.Default
{

    public class IsometricCood : Coordinate
    {

        int _left;
        int _right;

        public IsometricCood(int left, int right)
        {
            _left = left;
            _right = right;
        }

        public int get_left_value()
        {
            return _left;
        }

        public int get_right_value()
        {
            return _right;
        }

    }
}
