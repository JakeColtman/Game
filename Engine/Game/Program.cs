using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;
using Engine.Mappings;
using Engine.Mappings.Coordinates;
using Engine.Movement;
using Engine.Unit;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovementBus<TwoD> bus = new TwoDMovementBus();

            TwoDMap<IUnit> map = new TwoDMap<IUnit>(10);

            //Engine.Unit.UnitFactory unitFactory = new Engine.Unit.UnitFactory();
            //WeaponFactory weaponFactory = new WeaponFactory();

            //Engine.Unit.IUnit pikeMan = unitFactory.create(10, 100, 2, weaponFactory.create(WeaponType.Lance, 1000, 1));

            //unitMap.add_to_pos(pikeMan, new Coordinate(2, 1));

            //baseMap.print();
            //unitMap.print();

            //Console.ReadLine();
        }
    }
}
