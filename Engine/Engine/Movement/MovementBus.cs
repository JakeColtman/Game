using Engine.Mappings.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Movement
{

    public interface IMovementHandler<T>
    {
        bool will_allow_move(MovementRequest<T> request);
        bool move(MovementRequest<T> request);
    }

    public class MovementRequest<T>
    {
        public ICoordinate<TwoD> start;
        public ICoordinate<TwoD> end;
    }

    public interface IMovementBus<T>
    {
        bool add_listener(IMovementHandler<T> handler);
        bool add_blocking_listener(IMovementHandler<T> handler);
        bool request_a_move(MovementRequest<T> request);
    }

    public class TwoDMovementBus : IMovementBus<TwoD>
    {

        IList<IMovementHandler<TwoD>> _blocking_handlers;
        IList<IMovementHandler<TwoD>> _non_blocking_handlers;

        public TwoDMovementBus(IList<IMovementHandler<TwoD>> blocking_handlers, IList<IMovementHandler<TwoD>> non_blocking_handlers)
        {
            _blocking_handlers = blocking_handlers;
            _non_blocking_handlers = non_blocking_handlers;
        }

        public TwoDMovementBus() : this (new List<IMovementHandler<TwoD>>(), new List<IMovementHandler<TwoD>>())
        {

        }

        public bool add_blocking_listener(IMovementHandler<TwoD> handler)
        {
            _blocking_handlers.Add(handler);
            return true;
        }

        public bool add_listener(IMovementHandler<TwoD> handler)
        {
            _non_blocking_handlers.Add(handler);
            return true;
        }

        public bool request_a_move(MovementRequest<TwoD> request)
        {
            if (_blocking_handlers.All(x => x.will_allow_move(request)))
            {
                _blocking_handlers
                    .Select(x => x.move(request));

                _non_blocking_handlers.Select(x => (x.will_allow_move(request)) ? x.move(request) : false);

                return true;
            }

            else return false;
        }
    }
}
