using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Geometry.Coordinates;
using Engine.Geometry.Coordinates.Default;

namespace Engine.Geometry.Converters.Custom
{
    class Iso2DConverter : IConverter
    {
        public Coordinate get_point_from_coordinate(Coordinate coord)
        {
            if(!(coord is IsometricCood)) throw new NotImplementedException();
            return coord;
        }
    }
}
