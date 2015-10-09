using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mappings
{
    public class UnitMap : IMapping<IUnit>
    {

        Dictionary<ICoordinate, IUnit> lookup;
        
        public UnitMap()
        {
            lookup = new Dictionary<ICoordinate, IUnit>();
        }

        public bool add_to_pos(IUnit addition, ICoordinate coord)
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

        public IUnit get_pos(ICoordinate coord)
        {

            if (!lookup.ContainsKey(coord))
            {
                UnitFactory unitFactory = new UnitFactory();
                return unitFactory.create(0, 0, 0, new WeaponFactory().create(WeaponType.None, 0, 0));
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
