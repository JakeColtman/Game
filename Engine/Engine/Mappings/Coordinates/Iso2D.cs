using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mappings.Coordinates
{

    public enum Iso2D { left, right }

    public class Iso2DCoord : ICoordinate<Iso2D>
    {

        int _left;
        int _right;

        public Iso2DCoord(int left, int right)
        {
            _left = left;
            _right = right;
        }

        public ICoordinate<Iso2D> get_next(Vector<Iso2D> vector)
        {
            
            if (vector._dimension == Iso2D.left)
            {
                return new Iso2DCoord(_left + (int)vector._direction, _right);
            }
            else
            {
                return new Iso2DCoord(_left,  (int)vector._direction + _right);
            }
        }

        public int get_pos(Iso2D dimension)
        {
            if (dimension == Iso2D.left)
                return _left;
            return _right;
        }

        public override bool Equals(object obj)
        {
            ICoordinate<Iso2D> coord = obj as ICoordinate<Iso2D>;
            if ((System.Object)coord == null)
            {
                return false;
            }
            else
            {
                return Equals(coord);
            }
        }

        public bool Equals(ICoordinate<Iso2D> coord)
        {            
            return coord.get_pos(Iso2D.left) == _left && coord.get_pos(Iso2D.right) == _right;
        }

        public override int GetHashCode()
        {
            return (_left.ToString() + "-" + _right.ToString()).GetHashCode();
        }

    }
}
