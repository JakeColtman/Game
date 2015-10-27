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
    class MenCanOnlyMoveDiagonally : IMessageHandler
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
            
            Console.WriteLine("Assessing whether the man is moving diagonally");

            int leftMove = Math.Abs(req.end.get_dimension_value(Iso2D.left) - req.mover.get_pos().get_dimension_value(Iso2D.left));
            int rightMove = Math.Abs(req.end.get_dimension_value(Iso2D.right) - req.mover.get_pos().get_dimension_value(Iso2D.right));
            return leftMove > 0 && rightMove > 0;


        }
    }
}
