using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{

    public enum WeaponType { Sword, Axe, Lance, None }

    public interface IWeapon
    {
        WeaponType get_type();
        int get_weight();
        int get_power();
    }

    public class WeaponFactory
    {
        public IWeapon create(WeaponType type, int weight, int power)
        {
            return new Weapon(type, weight, power);
        }
    }

    public class Weapon : IWeapon
    {

        int power;
        int weight;
        WeaponType type;

        public Weapon(WeaponType type, int weight, int power)
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
