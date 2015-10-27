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
            return message is MovementRequest<TDimension>  || message is Engine.Attack.DestructionRequest<TDimension>;
        }

        public bool will_allow(Message message)
        {
            return true;
        }

        public bool process(Message message)
        {

            if(message is MovementRequest<TDimension>)
            {
                var req = (MovementRequest<TDimension>)message;
                _map.move(req.mover.get_pos(), req.end);
                req.mover.set_pos(req.end);
            }
            else
            {
                var req = (Engine.Attack.DestructionRequest<TDimension>)message;
                _map.remove_from_coord(req.position);
            }
            return true;
        }
    }
}
