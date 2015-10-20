using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{

    public interface IUnit
    {
        void attack(IUnit attackedBy);
        bool give_weapon(IWeapon newWeapon);
        int get_strength();
        int get_defence();
        int get_health();
        IWeapon get_weapon();
    }

    public class UnitFactory
    {

        public IUnit create(Mappings.ICoordinate coord, int health, int strength, int defence, IWeapon weapon)
        {
            return new Unit(health, strength, defence, weapon, new MovementHandler(coord));
        }

    }

    public class Unit : IUnit
    {
        int health;
        int strength;
        int defence;
        IWeapon weapon;
        IMoveable movement;


        public Unit(int health, int strength, int defence, IWeapon weapon, IMoveable movementHandler)
        {
            this.health = health;
            this.strength = strength;
            this.defence = defence;
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

        public int get_strength()
        {
            return this.strength;
        }

        public int get_defence()
        {
            return this.defence;
        }

        public int get_health()
        {
            return this.health;
        }

        public IWeapon get_weapon()
        {
            return this.weapon;
        }
    }
}
