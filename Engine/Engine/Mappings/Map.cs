using Engine.Coordinates;
using Engine.Mappings.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mappings
{
    
    public class TwoDMap<MappedType> : IMapWriteable<TwoD, MappedType>, IMapReadable<TwoD, MappedType>
    {

        MappedType[,] mapArray;
        int size;

        public TwoDMap(int size)
        {
            mapArray = new MappedType[size, size];

            this.size = size;

        }

        public bool add_to_coord(ICoordinate<TwoD> position, MappedType item)
        {
            mapArray[position.get_pos(TwoD.x), position.get_pos(TwoD.y)] = item;
            return true;
        }

        public MappedType get_item_at_coord(ICoordinate<TwoD> coord)
        {
            return mapArray[coord.get_pos(TwoD.x), coord.get_pos(TwoD.y)];
        }

        public bool move(ICoordinate<TwoD> startCoord, ICoordinate<TwoD> endCoord)
        {
            add_to_coord(endCoord, get_item_at_coord(endCoord));
            remove_from_coord(startCoord);
            return true;
        }

        public ICoordinate<TwoD> next_pos(ICoordinate<TwoD> coord, TwoD dimension, direction direction)
        {
            int incr = (direction == direction.forward) ? 1 : -1;
            int x = coord.get_pos(TwoD.x);
            int y = coord.get_pos(TwoD.y);
            switch (dimension)
            {
                case TwoD.x:
                    x += incr;
                    break;
                case TwoD.y:
                    y += incr;
                    break;
                default:
                    throw new NotImplementedException("Valid dimensions for this coord are x and y");

            }
            return new TwoDCoord(x, y);
        }

        public void print()
        {
            Console.WriteLine("I'm a square map of size " + size.ToString());
        }

        public bool remove_from_coord(ICoordinate<TwoD> position)
        {
            mapArray[position.get_pos(TwoD.x), position.get_pos(TwoD.y)] = default(MappedType);
            return true;
        }

        private bool within_array_bounds(ICoordinate<TwoD> coord)
        {
            return (coord.get_pos(TwoD.x) >= 0) && (coord.get_pos(TwoD.x) < size) && (coord.get_pos(TwoD.y) >= 0) && (coord.get_pos(TwoD.y) < size);
        }


    }
}
