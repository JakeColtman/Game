using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Geometry;
using Engine.Geometry.Coordinates;
using Engine.Geometry.Coordinates.Default;
using Engine.Geometry.Converters;

namespace Engine.Maps
{
    class IsometricMap : IMapReader<IPoint>
    {

        // Simple infinitely extendable 2D grid of points.  Will provide multiple different objects if asked for the same point 

        IConverter _converter;

        public IsometricMap(IConverter converter)
        {
            _converter = converter;
        }

        public IPoint get_from_coordinate(Coordinate coord)
        {

            IsometricCood correctDimCoord = _converter.get_point_from_coordinate(coord) as IsometricCood;

            return new IsometricPoint(correctDimCoord.get_left_value(), correctDimCoord.get_right_value());

        }

        public IPoint get_from_point(IPoint point)
        {
            throw new NotImplementedException();
        }
    }
}
