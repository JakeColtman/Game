using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mappings
{
    public class UnitMap : IMapping<Unit.IUnit>
    {

        Dictionary<ICoordinate, Unit.IUnit> lookup;
        
        public UnitMap()
        {
            lookup = new Dictionary<ICoordinate, Unit.IUnit>();
        }

        public bool add_to_pos(Unit.IUnit addition, ICoordinate coord)
        {

            if (!lookup.ContainsKey(coord))
            {
                lookup.Add(coord, addition);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public Unit.IUnit get_pos(ICoordinate coord)
        {

            if (!lookup.ContainsKey(coord))
            {
                Unit.UnitFactory unitFactory = new Unit.UnitFactory();
                return unitFactory.create(coord, new Unit.Stats(), new WeaponFactory().create(WeaponType.None, 0, 0));
            }
            else
            {
                return lookup[coord];
            }

        }

        public bool pos_exists(ICoordinate coord)
        {
            return lookup.ContainsKey(coord);
        }

        public void print()
        {
            Console.WriteLine("I am a unit mapping that contains " + lookup.Count.ToString() + " units");
            foreach(ICoordinate coord in lookup.Keys)
            {
                Console.WriteLine(coord.get_x_pos() + " - " + coord.get_y_pos());
            }
        }

        public bool remove_from_pos(ICoordinate coord)
        {
            if (pos_exists(coord))
            {
                lookup.Remove(coord);
            }
            return true;
        }
    }
}
