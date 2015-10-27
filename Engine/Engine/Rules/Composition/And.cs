using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Rules.Composition
{
    public class And : IRule
    {

        IRule _left;
        IRule _right;

        public And(IRule left, IRule right)
        {
            _left = left;
            _right = right;
        }

        public bool will_allow(Message message)
        {
            return _left.will_allow(message) && _right.will_allow(message);
        }
    }

    public class MultiAnd : IRule
    {

        IEnumerable<IRule> _handlers;

        public MultiAnd(IEnumerable<IRule> handlers)
        {
            _handlers = handlers;
        }

        public bool will_allow(Message message)
        {
            return _handlers.All(x => x.will_allow(message));
        }

    }

}
