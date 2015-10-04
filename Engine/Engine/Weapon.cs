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

    class Weapon
    {
    }
}
