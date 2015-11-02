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
    public class DraughtsUnitMap : IMapReader<Man>, IMapUpdater<Man>
    {

        IList<Man> men;
        IConverter _converter;

        public DraughtsUnitMap(IConverter converter)
        {
            _converter = converter;
            men = new List<Man>();
        }

        public bool add_to_map(Coordinate coord, Man addition)
        {
            men.Add(addition);
            Console.WriteLine(men[0].get_pos().get_id());
            return true;
        }

        public Man get_from_coordinate(Coordinate coord)
        {
            IsometricCood correctDimCoord = _converter.get_point_from_coordinate(coord) as IsometricCood;
            IPoint point = new DraughtsPoint(correctDimCoord.get_left_value(), correctDimCoord.get_right_value());
            Console.WriteLine(point.get_id());
            return men.Where(x => x.get_pos().get_id() == point.get_id()).First();
        }

        public bool remove_from_map(Coordinate coord)
        {
            IsometricCood correctDimCoord = _converter.get_point_from_coordinate(coord) as IsometricCood;
            IPoint point = new DraughtsPoint(correctDimCoord.get_left_value(), correctDimCoord.get_right_value());
            Console.WriteLine(point.get_id());
            men.Where(x => x.get_pos().get_id() != point.get_id());
            return true;
        }
    }
}
