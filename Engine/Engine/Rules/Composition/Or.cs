using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Rules.Composition
{
    namespace Engine.Rules.Composition
    {
        class And : IMessageHandler
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
    }

}
