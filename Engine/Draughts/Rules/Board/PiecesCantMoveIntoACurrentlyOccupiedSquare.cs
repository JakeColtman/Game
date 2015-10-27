using Engine;
using Engine.Mappings;
using Engine.Mappings.Coordinates;
using Engine.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draughts.Rules.Board
{
    class PiecesCantMoveIntoACurrentlyOccupiedSquare : IMessageHandler
    {

        SquareMap<Iso2D, Man> _map;

        public PiecesCantMoveIntoACurrentlyOccupiedSquare(SquareMap<Iso2D, Man> map )
        {
            _map = map;
        }

        public bool can_handle(Message message)
        {
            return false;
        }

        public bool process(Message message)
        {
            return true;
        }

        public bool will_allow(Message message)
        {
            if (!(message is MovementRequest<Iso2D>)) { return true; }

            var req = (MovementRequest<Iso2D>)message;

            Console.WriteLine("Assessing whether the move would take the piece into a space already occupied");

            return _map.get_item_at_coord(req.end) == null;

        }
    }
}
