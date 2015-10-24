using Engine.Mappings;
using Engine.Mappings.Coordinates;
using Engine.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Movement
{
    public class TwoDMapHandler : IMovementHandler<TwoD>
    {
        TwoDMap<IUnit> _map;

        public TwoDMapHandler(TwoDMap<IUnit> map)
        {
            _map = map;
        }

        public bool move(MovementRequest<TwoD> request)
        {
            Console.WriteLine("Starting move");
            return _map.move(request.start, request.end);
        }

        public bool will_allow_move(MovementRequest<TwoD> request)
        {
            return true;
        }
    }
}
