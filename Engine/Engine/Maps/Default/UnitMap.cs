using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Geometry;
using Engine.Geometry.Coordinates;
using Engine.Unit;
using Engine.Geometry.Converters;

namespace Engine.Maps.Default
{
    public class UnitMap : IHandler, IMapReader<IEntity>
    {
        //This acts as a decorator over the top of a point map to keep a tab on where all units are
        //It also acts as a handler, taking messages and allowing rollback

        IDictionary<IPoint, IEntity> _lookup;
        IConverter _converter;
        IMapReader<IPoint> _pointMap;

        public UnitMap(Dictionary<IPoint, IEntity> unitPositions, IConverter converter, IMapReader<IPoint> pointMap)
        {
            _lookup = unitPositions;
            _converter = converter;
            _pointMap = pointMap;
        }

        public bool commit()
        {
            throw new NotImplementedException();
        }

        public IEntity get_from_coordinate(Coordinate coord)
        {
            return _lookup[_pointMap.get_from_coordinate(_converter.get_point_from_coordinate(coord))];
        }

        public bool pass_message(Message message)
        {
            throw new NotImplementedException();
        }

        public bool rollback()
        {
            throw new NotImplementedException();
        }
    }
}
