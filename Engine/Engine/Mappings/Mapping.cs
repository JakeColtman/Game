using Engine.Mappings.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mappings
{

    public interface IMapWriteable<T>
    {
        bool can_move(ICoordinate<T> startCoord, ICoordinate<T> endCoord);
        bool move(ICoordinate<T> startCoord, ICoordinate<T> endCoord);
    }

    public interface IMapReadable<T, S>
    {
        void print();
        S get_pos(ICoordinate<T> coord);
        bool pos_exists(ICoordinate<T> coord);
        ICoordinate<T> next_pos(ICoordinate<T> coord, T dimension, direction direction);
    }
    

}
