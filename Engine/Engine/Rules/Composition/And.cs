using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Rules.Composition
{
    public class And : IMessageHandler
    {

        IMessageHandler _left;
        IMessageHandler _right;

        public And(IMessageHandler left, IMessageHandler right)
        {
            _left = left;
            _right = right;
        }

        public bool can_handle(Message message)
        {
            return _left.can_handle(message) && _right.can_handle(message);
        }

        public bool process(Message message)
        {
            return _left.process(message) && _right.process(message);
        }

        public bool will_allow(Message message)
        {
            return _left.will_allow(message) && _right.will_allow(message);
        }
    }

    public class MultiAnd : IMessageHandler
    {

        IEnumerable<IMessageHandler> _handlers;

        public MultiAnd(IEnumerable<IMessageHandler> handlers)
        {
            _handlers = handlers;
        }

        public bool can_handle(Message message)
        {
            return _handlers.All(x => x.can_handle(message));
        }

        public bool process(Message message)
        {
            return _handlers.Select(x => x.process(message)).All(x => x);
        }

        public bool will_allow(Message message)
        {
            return _handlers.All(x => x.will_allow(message));
        }
    }

}
