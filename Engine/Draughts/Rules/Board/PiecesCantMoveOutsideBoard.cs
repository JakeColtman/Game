using Engine;
using Engine.Mappings.Coordinates;
using Engine.Movement;
using Engine.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draughts.Rules.Board
{
    class PiecesCantMoveOutsideBoard : IRule
    {

        int _maxSize;

        public PiecesCantMoveOutsideBoard(int maxSize)
        {
            _maxSize = maxSize;
        }
        
        public bool will_allow(Message message)
        {
            if (!(message is MovementRequest<Iso2D>)) { return true; }

            var req = (MovementRequest<Iso2D>)message;

            Console.WriteLine("Assessing whether the move would take the piece outside the board");

            int currentLeft = req.mover.get_pos().get_dimension_value(Iso2D.left);
            int currentRight = req.mover.get_pos().get_dimension_value(Iso2D.right);

            int deltaLeft = (int)req.movement.get_vector_for_dimension(Iso2D.left).get_direction() * req.movement.get_vector_for_dimension(Iso2D.left).get_distance();
            int deltaRight = (int)req.movement.get_vector_for_dimension(Iso2D.right).get_direction() * req.movement.get_vector_for_dimension(Iso2D.right).get_distance();

            bool nonNeg = currentLeft + deltaLeft >= 0 && currentRight + deltaRight >= 0;
            bool nonOverMax = currentLeft + deltaLeft <= _maxSize  && currentRight + deltaRight >= _maxSize;
           
            return nonNeg && nonOverMax;

        }
    }
}
