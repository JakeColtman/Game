using Engine.Mappings.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mappings
{
    
    public class SquareMap<TDimension, TMapped> : IMapWriteable<TDimension, TMapped>, IMapReadable<TDimension, TMapped>
    {

        Dictionary<ICoordinate<TDimension>, TMapped> _lookup;
        
        public SquareMap()
        {
            _lookup = new Dictionary<ICoordinate<TDimension>, TMapped>();
        }

        public bool add_to_coord(ICoordinate<TDimension> position, TMapped item)
        {
            _lookup.Add(position, item);
            return true;
        }

        public TMapped get_item_at_coord(ICoordinate<TDimension> coord)
        {
            if (_lookup.ContainsKey(coord)) return _lookup[coord];
            else return default(TMapped);
        }

        public bool move(ICoordinate<TDimension> startCoord, ICoordinate<TDimension> endCoord)
        {
            Console.WriteLine(startCoord);
            add_to_coord(endCoord, get_item_at_coord(startCoord));
            Console.WriteLine("Adding to new coord");
            remove_from_coord(startCoord);
            return true;
        }

        public void print()
        {
            Console.WriteLine("I'm a square map with " + _lookup.Keys.Count.ToString() + " items in");
            
        }

        public bool remove_from_coord(ICoordinate<TDimension> position)
        {
            _lookup.Remove(position);
            return true;
        }


    }
}
