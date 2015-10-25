using Engine.Mappings.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Coordinates
{

    public class TwoDCoord : ICoordinate<TwoD>
    {

        int x;
        int y;

        public TwoDCoord(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public ICoordinate<TwoD> get_next(TwoD dim, direction dir)
        {

            int incr = 0;

            switch (dir)
            {
                case direction.backwards:
                    incr = -1;
                    break;
                case direction.forward:
                    incr = 1;
                    break;
                default:
                    throw new NotImplementedException("Only forwards and backwards are viable directions");
                   
            }

            if(dim == TwoD.x)
            {
                return new TwoDCoord(x + incr, y);
            }
            else
            {
                return new TwoDCoord(x, y + incr);
            }

        }

        public int get_pos(TwoD dimension)
        {
            switch (dimension)
            {
                case TwoD.x:
                    return x;
                case TwoD.y:
                    return y;
                default:
                    throw new NotImplementedException("Valid dimensions for this coord are x and y");

            }
        }
        
    }
}
