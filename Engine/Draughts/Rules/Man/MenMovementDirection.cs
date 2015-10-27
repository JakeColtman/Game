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
    public class WhiteMenMoveOnlyUpBoard : IMessageHandler
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

            if (req.mover.get_side() == Engine.Player.TwoPlayers.black) return true;
            Console.WriteLine("Assessing whether white piece moving up board");
            return (req.end.get_dimension_value(Iso2D.left) >= req.mover.get_pos().get_dimension_value(Iso2D.left)) &
                        (req.end.get_dimension_value(Iso2D.right) >= req.mover.get_pos().get_dimension_value(Iso2D.right));

        }       
    }

    public class BlackMenMoveDownBoard : IMessageHandler
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

            if (req.mover.get_side() == Engine.Player.TwoPlayers.white) return true;
            Console.WriteLine("Assessing whether black piece moving down board");
            return (req.end.get_dimension_value(Iso2D.left) <= req.mover.get_pos().get_dimension_value(Iso2D.left)) &
                        (req.end.get_dimension_value(Iso2D.right) <= req.mover.get_pos().get_dimension_value(Iso2D.right));

        }
    }
    
}
