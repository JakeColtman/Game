using Engine.Mappings.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mappings.Coordinates
{

    public enum TwoD { x, y }

    public class TwoDCoord : ICoordinate<TwoD>
    {

        int x;
        int y;

        public TwoDCoord(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public ICoordinate<TwoD> get_next(Direction direction)
        {

            if(vector._dimension == TwoD.x)
            {
                return new TwoDCoord(x + (int)vector._direction , y);
            }
            else
            {
                return new TwoDCoord(x, y + (int) vector._direction);
            }

        }

        public List<TwoD> get_dimensions()
        {
            return new List<TwoD>() { TwoD.x, TwoD.y };
        }

        public int get_dimension_value(TwoD dimension)
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
