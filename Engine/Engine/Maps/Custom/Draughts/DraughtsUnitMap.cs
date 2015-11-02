using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Geometry;
using Engine.Geometry.Coordinates;
using Engine.Unit.Custom.Draughts;
using Engine.Geometry.Converters;
using Engine.Geometry.Coordinates.Default;
using Engine.Geometry.Points.Custom;

namespace Engine.Maps.Custom
{
    class DraughtsUnitMap : IMapReader<Man>
    {

        IList<Man> men;
        IConverter _converter;

        public DraughtsUnitMap(IConverter converter)
        {
            _converter = converter;
            men = new List<Man>();
        }

        public Man get_from_coordinate(Coordinate coord)
        {
            IsometricCood correctDimCoord = _converter.get_point_from_coordinate(coord) as IsometricCood;
            IPoint point = new DraughtsPoint(correctDimCoord.get_left_value(), correctDimCoord.get_right_value());
            return men.Where(x => x.get_pos().get_id() == point.get_id()).First();

        }

    }
}
