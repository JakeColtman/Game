using Engine.Geometry.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Geometry.Converters.cs
{
    public interface IConverter
    {
        IPoint get_point_from_coordinate(Coordinate coord);
    }
}
