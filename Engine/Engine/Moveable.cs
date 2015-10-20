using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{

    public interface IMoveable<T>
    {
        bool can_move_to(Mappings.ICoordinate coord);
        bool move_to(Mappings.ICoordinate coord);
        bool add_movement_subscriber(Mappings.IMapping<T> map);
    }

}
