using Engine;
using Engine.Mappings.Coordinates;
using Engine.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draughts.Rules
{
    class MenCanOnlyMoveOneSquare : IMessageHandler
    {
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

            Console.WriteLine("Assessing whether the man is only move one square");

            return req.movement.get_vector_for_dimension(Iso2D.left).get_distance() < 2 && req.movement.get_vector_for_dimension(Iso2D.right).get_distance() < 2;

        }
    }
}
