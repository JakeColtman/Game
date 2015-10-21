using Engine.Coordinates;
using Engine.Mappings.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mappings
{
    
    public class TwoDMap<MappedType> : IMapWriteable<ICoordinate<TwoD>>, IMapReadable<ICoordinate<TwoD>, MappedType>
    {

        MappedType[,] mapArray;
        int size;

        public TwoDMap(int size)
        {
            mapArray = new MappedType[size, size];

            this.size = size;

        }

        public bool can_move(ICoordinate<ICoordinate<TwoD>> startCoord, ICoordinate<ICoordinate<TwoD>> endCoord)
        {
            throw new NotImplementedException();
        }

        public MappedType get_pos(ICoordinate<TwoD> coord)
        {
            return mapArray[coord.get_pos(TwoD.x), coord.get_pos(TwoD.y)];
        }

        public bool move(ICoordinate<ICoordinate<TwoD>> startCoord, ICoordinate<ICoordinate<TwoD>> endCoord)
        {
            throw new NotImplementedException();
        }

        public void print()
        {
            Console.WriteLine("I'm a square map of size " + size.ToString());
        }
        
        private bool within_array_bounds(ICoordinate<TwoD> coord)
        {
            return (coord.get_pos(TwoD.x) >= 0) && (coord.get_pos(TwoD.x) < size) && (coord.get_pos(TwoD.y) >= 0) && (coord.get_pos(TwoD.y) < size);
        }


    }
}
