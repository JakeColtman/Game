using Engine;
using Engine.Mappings;
using Engine.Mappings.Coordinates;
using Engine.Movement;
using Engine.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draughts.Rules.Attack
{
    class ManJumpsTheAttackedPiece : IRule
    {
        public Message process(Message message)
        {
            //Make the same move again to jump to the next space
            MovementRequest<Iso2D> req = message as MovementRequest<Iso2D>;
            return req;
        }
                
    }
}
