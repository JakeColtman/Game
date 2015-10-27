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
    class ManMovingIntoOccupiedSquareIsAttack : IMessageHandler
    {

        SquareMap<Iso2D, Man> _map;
        IEngine _engine;

        public ManMovingIntoOccupiedSquareIsAttack(IEngine engine, SquareMap<Iso2D, Man> map )
        {
            _map = map;
            _engine = engine;
        }

        public bool can_handle(Message message)
        {
            return message is MovementRequest<Iso2D>;
        }

        public bool process(Message message)
        {
            var req = (MovementRequest<Iso2D>)message;

            Console.WriteLine("Assessing whether the move would take the piece into a space already occupied");

            if (_map.get_item_at_coord(req.end) != null)
            {
                _engine.send_message(new Engine.Attack.AttackRequest<Iso2D>() { attacked = _map.get_item_at_coord(req.end), attacker = req.mover });
            }

            return true;
        }

        public bool will_allow(Message message)
        {
            return true;
        }
    }
}
