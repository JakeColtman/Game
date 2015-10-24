using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Attack
{

    class SimpleAttackCommand : IMessage
    {

        Unit.IUnit _attacker;
        Unit.IUnit _attacked;

        public SimpleAttackCommand(Unit.IUnit attackingUnit, Unit.IUnit defendingUnit)
        {
            _attacker = attackingUnit;
            _attacked = defendingUnit;
        }

        public bool execute()
        {
            return _attacked.get_stats_updater().attack_with_stats(_attacker.get_stats_reader());
        }

        public bool undo()
        {
            return _attacked.get_stats_updater().heal_with_stats(_attacker.get_stats_reader());
        }


    }
}
