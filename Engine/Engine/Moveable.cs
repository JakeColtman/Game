using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Mappings;

namespace Engine
{

    public interface IMoveable
    {
        bool try_and_move(Mappings.ICoordinate end_coord);
        bool add_movement_subscriber(Mappings.IMapUpdatable map);
    }

    public class MovementHandler : IMoveable
    {
        IList<Mappings.IMapUpdatable> subscribers;
        Mappings.ICoordinate current_pos;

        public MovementHandler(Mappings.ICoordinate pos)
        {
            current_pos = pos;
            subscribers = new List<Mappings.IMapUpdatable>();
        }

        public bool add_movement_subscriber(IMapUpdatable map)
        {
            try {
                subscribers.Add(map);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool try_and_move(ICoordinate end_coord)
        {
            if (subscribers.All(x => x.can_move(current_pos, end_coord)))
                return subscribers.Select(x => x.move(current_pos, end_coord)).All(x => x);
            else return false;       
        }
    }


}
