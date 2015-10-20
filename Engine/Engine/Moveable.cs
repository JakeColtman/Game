using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{

    public interface IMoveable
    {
        bool try_and_move(Mappings.ICoordinate end_coord);
        bool add_movement_subscriber(Mappings.IMapUpdatable map);
    }

    public class MovementHandler
    {
        IList<Mappings.IMapUpdatable> subscribers;

    }


}
