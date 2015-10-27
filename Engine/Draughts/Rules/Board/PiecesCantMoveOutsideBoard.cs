using Engine;
using Engine.Mappings.Coordinates;
using Engine.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draughts.Rules.Board
{
    class PiecesCantMoveOutsideBoard : IMessageHandler
    {

        int _maxSize;

        public PiecesCantMoveOutsideBoard(int maxSize)
        {
            _maxSize = maxSize;
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

            Console.WriteLine("Assessing whether the move would take the piece outside the board");

            bool nonNeg = req.end.get_dimension_value(Iso2D.left) >= 0 && req.end.get_dimension_value(Iso2D.right) >= 0;
            bool nonOverMaxed = req.end.get_dimension_value(Iso2D.left) <= _maxSize && req.end.get_dimension_value(Iso2D.right) <= _maxSize;

            return nonNeg && nonOverMaxed;

        }
    }
}
