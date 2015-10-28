using Engine.Mappings.Coordinates;
using Engine.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mappings
{
    public class SquareMapEventHandler<TDimension, TMapped> : IHandler
    {

        SquareMap<TDimension, TMapped> _confirmed_map;
        SquareMap<TDimension, TMapped> _unconfirmed_map;

        public SquareMapEventHandler(SquareMap<TDimension, TMapped> map)
        {
            _confirmed_map = map;
            _unconfirmed_map = map;
        }

        public bool commit()
        {
            _confirmed_map = _unconfirmed_map;
            return true;
        }

        public bool pass_message(Message message)
        {
            if(message is MovementRequest)
            {
                var req = message as MovementRequest;
                _unconfirmed_map = _unconfirmed_map.move(req.mover.get_pos(), req.get_final_position());
                req.mover.set_pos(req.mover.get_pos());
            }
            else
            {
               // var req = (Engine.Attack.DestructionRequest<TDimension>)message;
               // _map.remove_from_coord(req.position);
            }
            return true;
        }

        public bool rollback()
        {
            _unconfirmed_map = _confirmed_map;
            return false;
        }
    }
}
