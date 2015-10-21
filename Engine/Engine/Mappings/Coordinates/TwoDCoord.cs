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

        public ICoordinate<TwoD> increment(TwoD dimension, direction direction)
        {


        }
    }
}
