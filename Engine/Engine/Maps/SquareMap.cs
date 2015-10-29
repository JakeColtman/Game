using Engine.Mappings.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Maps
{
    
    public class SquareMap<TDimension, TMapped>
    {

        Dictionary<ICoordinate<TDimension>, TMapped> _lookup;
        
        public SquareMap() : this(new Dictionary<ICoordinate<TDimension>, TMapped>())
        {
        }

        public SquareMap(Dictionary<ICoordinate<TDimension>, TMapped> dictionary)
        {
            _lookup = dictionary;
        }

        public SquareMap<TDimension, TMapped> add_to_coord(ICoordinate<TDimension> position, TMapped item)
        {
            _lookup.Add(position, item);
            return new SquareMap<TDimension, TMapped>(_lookup);            
        }

        public TMapped get_item_at_coord(ICoordinate<TDimension> coord)
        {
            if (_lookup.ContainsKey(coord)) return _lookup[coord];
            else return default(TMapped);
        }

        public SquareMap<TDimension, TMapped> move(ICoordinate<TDimension> startCoord, ICoordinate<TDimension> endCoord)
        {
            return add_to_coord(endCoord, get_item_at_coord(startCoord)).remove_from_coord(startCoord);
        }

        public void print()
        {
            Console.WriteLine("I'm a square map with " + _lookup.Keys.Count.ToString() + " items in");
            
        }

        public SquareMap<TDimension, TMapped> remove_from_coord(ICoordinate<TDimension> position)
        {
            _lookup.Remove(position);
            return new SquareMap<TDimension, TMapped>(_lookup);
        }


    }
}
