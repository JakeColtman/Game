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
    class PiecesCantMoveOutsideBoard : IBlockingRule
    {

        int _maxSize;

        public PiecesCantMoveOutsideBoard(int maxSize)
        {
            _maxSize = maxSize;
        }
        
        public bool will_allow(Message message)
        {
            if (!(message is Iso2DMovementRequest)) { return true; }

            var req = message as Iso2DMovementRequest;

            Console.WriteLine("Assessing whether the move would take the piece outside the board");
                        
            bool nonNeg = req.get_final_position().get_dimension_value(Iso2D.left) >= 0 && req.get_final_position().get_dimension_value(Iso2D.right) >= 0;
            bool nonOverMax = req.get_final_position().get_dimension_value(Iso2D.left) <= _maxSize  && req.get_final_position().get_dimension_value(Iso2D.right) >= _maxSize;
           
            return nonNeg && nonOverMax;

        }
    }
}
