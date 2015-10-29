using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Geometry;
using Engine.Geometry.Coordinates;
using Engine.Unit;

namespace Engine.Maps.Default
{
    class UnitMap : IHandler, IMapReader<IEntity>
    {
        //This acts as a decorator over the top of a point map to keep a tab on where all units are
        //It also acts as a handler, taking messages and allowing rollback

        IDictionary<IPoint, IEntity> _lookup;
        IDictionary<>

        public UnitMap(Dictionary<IPoint, IEntity> unitPositions)
        {
            _lookup = unitPositions;
        }

        public bool commit()
        {
            throw new NotImplementedException();
        }

        public IEntity get_from_coordinate(Coordinate coord)
        {
            throw new NotImplementedException();
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
