using Engine.Mappings.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Movement
{
    public interface IMoveable<T>
    {
        bool try_and_move(ICoordinate<T> end_coord);
        ICoordinate<T> get_current_pos();
    }
}
