using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Geometry;
using Engine.Geometry.Coordinates;

namespace Engine.Maps.Default
{
    class UnitMap : IHandler, IPointMapReader
    {
        public bool commit()
        {
            throw new NotImplementedException();
        }

        //This acts as a decorator over the top of a point map to keep a tab on where all units are
        //It also acts as a handler, taking messages and allowing rollback
        public IPoint get_point_by_coordinate(Coordinate coord)
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
