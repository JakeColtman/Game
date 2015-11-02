using Engine.Geometry;
using Engine.Maps.Custom;
using Engine.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Handlers.Custom
{
    class DraughtsMovementHandler : IHandler
    {

        DraughtsUnitMap _map;

        public DraughtsMovementHandler(DraughtsUnitMap map)
        {
            _map = map;
        }

        public bool commit()
        {
            return true;
        }

        public bool pass_message(Message message)
        {

            //This will allow any movement that ends in a free square
            //Can be updated later

            if (!(message is MovementRequest)) return true;

            MovementRequest req = message as MovementRequest;
            if (!(_map.get_from_point(req.get_final_position()) == null)) return false;
            IEnumerable<Direction> directions = req.get_movement().get_directions();
            foreach(Direction dir in directions)
            {
                req.get_mover().move_in_direction(dir);
            }

            return true;           

        }

        public bool rollback()
        {
            throw new NotImplementedException();
        }
    }
}
