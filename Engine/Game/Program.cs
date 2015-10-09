using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;
using Engine.Mappings;
namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine.Mappings.IMapping<ICoordinate> baseMap = new CoordinateMap(3);

            IMapping<IUnit> unitMap = new UnitMap();

            UnitFactory unitFactory = new UnitFactory();
            WeaponFactory weaponFactory = new WeaponFactory();

            IUnit pikeMan = unitFactory.create(10, 100, 2, weaponFactory.create(WeaponType.Lance, 1000, 1));

            unitMap.add_to_pos(pikeMan, new Coordinate(2, 1));

            baseMap.print();
            unitMap.print();

            Console.ReadLine();
        }
    }
}
