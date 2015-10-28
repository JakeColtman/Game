using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Rules.Composition
{
    public class And : IBlockingRule
    {

        IBlockingRule _left;
        IBlockingRule _right;

        public And(IBlockingRule left, IBlockingRule right)
        {
            _left = left;
            _right = right;
        }

        public bool will_allow(Message message)
        {
            return _left.will_allow(message) && _right.will_allow(message);
        }
    }

    public class MultiAnd : IBlockingRule
    {

        IEnumerable<IBlockingRule> _handlers;

        public MultiAnd(IEnumerable<IBlockingRule> handlers)
        {
            _handlers = handlers;
        }

        public bool will_allow(Message message)
        {
            return _handlers.All(x => x.will_allow(message));
        }

    }

}
