using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{

    enum WeaponType { Sword, Axe, Lance }

    interface IWeapon
    {
        WeaponType get_type();
        int get_weight();
        int get_power();
    }

    class WeaponFactory
    {
        IWeapon create(WeaponType type, int weight, int power)
        {
            return new Weapon(type, weight, power);
        }
    }

    class Weapon : IWeapon
    {

        int power;
        int weight;
        WeaponType type;

        public Weapon(WeaponType type, int power, int weight)
        {
            this.power = power;
            this.weight = weight;
            this.type = type;
        }

        public int get_power()
        {
            return power;
        }

        public WeaponType get_type()
        {
            return type;
        }

        public int get_weight()
        {
            return weight;
        }
    }
}
