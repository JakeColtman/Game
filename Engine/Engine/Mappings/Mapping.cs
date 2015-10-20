using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mappings
{
    public interface IMapping<T>
    {
        void print();
        T get_pos(ICoordinate coord);
        bool pos_exists(ICoordinate coord);
        bool add_to_pos(T addition, ICoordinate coord);
        bool remove_from_pos(ICoordinate coord);
    }

    public interface IMapUpdatable
    {
        bool can_move(ICoordinate startCoord, ICoordinate endCoord);
        bool move(ICoordinate startCoord, ICoordinate endCoord);
    }

    public interface IMapUpdateReadable<T>
    {
        void print();
        T get_pos(ICoordinate coord);
        bool pos_exists(ICoordinate coord);
    }
    

}
