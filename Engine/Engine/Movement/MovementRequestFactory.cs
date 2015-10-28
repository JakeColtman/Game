using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Mappings;
using Engine.Mappings.Coordinates;

namespace Engine.Movement
{
    public interface ICoordinateFactory<T>
    {
        ICoordinate<T> create(Dictionary<T, int> values);
    }

    public class Iso2DCoordinateFactory : ICoordinateFactory<Iso2D>
    {
        public ICoordinate<Iso2D> create(Dictionary<Iso2D, int> values)
        {
            return new Iso2DCoord(values[Iso2D.left], values[Iso2D.right]);
        }
    }
}
