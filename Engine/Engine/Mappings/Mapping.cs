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
        bool remove_from_coord(ICoordinate<T> position);
    }

    public interface IMapReadable<T, S>
    {
        void print();
        S get_item_at_coord(ICoordinate<T> coord);
    }
    

}
