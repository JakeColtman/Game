using Engine.Mappings.Coordinates;
using Engine.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mappings
{
    public class SquareMapEventHandler<TDimension, TMapped> : IMessageHandler
    {

        SquareMap<TDimension, TMapped> _map;

        public SquareMapEventHandler(SquareMap<TDimension, TMapped> map)
        {
            _map = map;
        }
       
        public bool can_handle(Message message)
        {
            Console.WriteLine("Can square map handler the move?");
            return message is MovementRequest<TDimension>;
        }

        public bool will_allow(Message message)
        {
            return true;
        }

        public bool process(Message message)
        {
            var req = (MovementRequest<TDimension>)message;
            _map.move(req.mover.get_pos(),req.end);
            return true;
        }
    }
}
