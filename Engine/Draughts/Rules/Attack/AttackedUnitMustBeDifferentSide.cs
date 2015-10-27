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
    class AttackedUnitMustBeDifferentSide : IRule
    {

        SquareMap<Iso2D, Man> _map;

        public AttackedUnitMustBeDifferentSide(SquareMap<Iso2D, Man> map)
        {
            _map = map;
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
