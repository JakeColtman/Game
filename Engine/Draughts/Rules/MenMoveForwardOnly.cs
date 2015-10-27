using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;
using Engine.Mappings.Coordinates;
using Engine.Movement;

namespace Draughts.Rules
{
    public class MenMoveForwardOnly : IMessageHandler
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
            
            return (req.end.get_pos(Iso2D.left) >= req.mover.get_pos().get_pos(Iso2D.left)) &
                        (req.end.get_pos(Iso2D.right) >= req.mover.get_pos().get_pos(Iso2D.right));

        }
       
    }
}
