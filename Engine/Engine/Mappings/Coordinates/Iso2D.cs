using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mappings.Coordinates
{

    public enum Iso2D { left, right }

    class Iso2DCoord : ICoordinate<Iso2D>
    {

        int _x;
        int _y;

        public Iso2DCoord(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public ICoordinate<Iso2D> get_next(Vector<Iso2D> vector)
        {
            
            if (vector._dimension == Iso2D.left)
            {
                return new Iso2DCoord(_x - 1, (int)vector._direction + _y);
            }
            else
            {
                return new Iso2DCoord(_x + 1, (int)vector._direction + _y);
            }
        }

        public int get_pos(Iso2D dimension)
        {
            if (dimension == Iso2D.left)
                return _x;
            return _y;
        }
    }
}
