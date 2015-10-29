using Engine.Geometry.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Geometry.Converters
{
    public interface IConverter
    {
        Coordinate get_point_from_coordinate(Coordinate coord);
    }
}
