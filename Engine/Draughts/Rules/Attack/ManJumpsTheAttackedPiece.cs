using Engine;
using Engine.Mappings;
using Engine.Mappings.Coordinates;
using Engine.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draughts.Rules.Attack
{
    class ManJumpsTheAttackedPiece : IMessageHandler
    {

        SquareMap<Iso2D, Man> _map;
        IEngine _engine;

        public ManJumpsTheAttackedPiece(IEngine engine, SquareMap<Iso2D, Man> map)
        {
            _map = map;
            _engine = engine;
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
            if (!(message is Engine.Attack.AttackRequest<Iso2D>)) { return true; }

            var req = (Engine.Attack.AttackRequest<Iso2D>)message;

            Console.WriteLine("Determining whether the attacked piece is of the opposite side");

            return req.attacked.get_side() != req.attacker.get_side();

        }
    }
}
