using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;
using Engine.Mappings.Coordinates;
using Engine.Movement;
using Engine.Rules;

namespace Draughts.Rules
{
    public class WhiteMenMoveOnlyUpBoard : IRule
    {
        public bool will_allow(Message message)
        {

            if (!(message is MovementRequest<Iso2D>)) { return true; }

            var req = (MovementRequest<Iso2D>)message;

            if (req.mover.get_side() == Engine.Player.TwoPlayers.black) return true;
            Console.WriteLine("Assessing whether white piece moving up board");
            return req.movement.get_vector_for_dimension(Iso2D.left).get_direction() == Direction.forward &&
                    req.movement.get_vector_for_dimension(Iso2D.right).get_direction() == Direction.forward

        }       
    }

    public class BlackMenMoveDownBoard : IRule
    {
     
        public bool will_allow(Message message)
        {

            if (!(message is MovementRequest<Iso2D>)) { return true; }

            var req = (MovementRequest<Iso2D>)message;

            if (req.mover.get_side() == Engine.Player.TwoPlayers.white) return true;
            Console.WriteLine("Assessing whether black piece moving down board");
            return req.movement.get_vector_for_dimension(Iso2D.left).get_direction() == Direction.backwards &&
                    req.movement.get_vector_for_dimension(Iso2D.right).get_direction() == Direction.backwards

        }
    }
    
}
