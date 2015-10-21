using Engine.Mappings.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mappings
{

    public interface IMapWriteable<T, S>
    {
        bool move(ICoordinate<T> startCoord, ICoordinate<T> endCoord);
        bool add_to_coord(ICoordinate<T> position, S item);
        bool remove_from_coord(ICoordinate<T> position, S item);
    }

    public interface IMapReadable<T, S>
    {
        void print();
        S get_pos(ICoordinate<T> coord);
        bool pos_exists(ICoordinate<T> coord);
        ICoordinate<T> next_pos(ICoordinate<T> coord, T dimension, direction direction);
    }
    

}
