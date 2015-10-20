using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Unit
{

    public struct Stats
    {
        int health { get; set; }
        int strength { get; set; }
        int defence { get; set; }
    }

    public interface IUnit
    {
        void attack(IUnit attackedBy);
        bool give_weapon(IWeapon newWeapon);
        Stats get_stats();
        IWeapon get_weapon();
    }



    public class Unit : IUnit
    {
        Stats stats;
        IWeapon weapon;
        IMoveable movement;


        public Unit(Stats stats, IWeapon weapon, IMoveable movementHandler)
        {
            this.stats = stats;
            this.weapon = weapon;
            this.movement = movementHandler;
        }

        public void attack(IUnit attackedBy)
        {
            throw new NotImplementedException();
        }

        public bool give_weapon(IWeapon newWeapon)
        {
            try {
                this.weapon = newWeapon;
                return true;
            }
            catch
            {
                return false;
            }

        }

        public Stats get_stats()
        {
            return this.stats;
        }

        public IWeapon get_weapon()
        {
            return this.weapon;
        }
    }
}
