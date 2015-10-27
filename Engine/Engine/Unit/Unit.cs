using Engine.Mappings.Coordinates;
using Engine.Movement;
using Engine.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Unit
{
    public interface IEntity<T>
    {
        TwoPlayers get_side();
        ICoordinate<T> get_pos();
        bool set_pos(ICoordinate<T> new_pos);
        //IMoveable<T> get_movement_handler();
    }
    
}
