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
            //IMovementBus<TwoD> bus = new TwoDMovementBus();

            //TwoDMap<IUnit> map = new TwoDMap<IUnit>(10);
            //TwoDMapHandler handler = new TwoDMapHandler(map);
            //bus.add_blocking_listener(handler);

            //UnitFactory unitFactory = new UnitFactory(map, map, bus);
            
            
            //WeaponFactory weaponFactory = new WeaponFactory();

            //SimpleStats exampleStat = new SimpleStats();

            //IUnit pikeMan = unitFactory.create(new TwoDCoord(1,2), exampleStat, exampleStat, weaponFactory.create(WeaponType.Lance, 1000, 1));

            //map.print();

            //pikeMan.get_movement().try_and_move(new TwoDCoord(1, 3));
            //pikeMan.get_movement().try_and_move(new TwoDCoord(3, 5));
            //Console.WriteLine(map.get_item_at_coord(new TwoDCoord(3, 5)).get_stats_reader().get_defence());

            //Console.Read();

            ////unitMap.add_to_pos(pikeMan, new Coordinate(2, 1));

            //baseMap.print();
            //unitMap.print();

            //Console.ReadLine();
        }
    }
}
