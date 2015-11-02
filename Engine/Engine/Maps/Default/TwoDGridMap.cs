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
    class TwoDGridMap : IMapReader<IPoint>
    {

        IConverter _converter;

        public TwoDGridMap(IConverter converter)
        {
            _converter = converter;
        }        

        public IPoint get_from_coordinate(Coordinate coord)
        {

            TwoDGridCoord correctDimCoord = _converter.get_point_from_coordinate(coord) as TwoDGridCoord;

            return new TwoDSquareGridPoint(correctDimCoord.get_x_value(), correctDimCoord.get_y_value());
        }

        public IPoint get_from_point(IPoint point)
        {
            throw new NotImplementedException();
        }
    }
}
