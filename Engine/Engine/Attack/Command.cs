using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Attack
{

    class AttackCommand : IMessage
    {

        Unit.IUnit _attacker;
        Unit.IUnit _attacked;

        public AttackCommand(Unit.IUnit attackingUnit, Unit.IUnit defendingUnit)
        {
            _attacker = attackingUnit;
            _attacked = defendingUnit;
        }

        public bool execute()
        {
            return true;
        }

        public bool undo()
        {
            return true;
        }


    }
}
