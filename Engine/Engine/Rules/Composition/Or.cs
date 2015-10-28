using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Rules.Composition
{
    namespace Engine.Rules.Composition
    {
        public class Or : IBlockingRule
        {

            IBlockingRule _left;
            IBlockingRule _right;

            public Or(IBlockingRule left, IBlockingRule right)
            {
                _left = left;
                _right = right;
            }
            
            public bool will_allow(Message message)
            {
                return _left.will_allow(message) || _right.will_allow(message);
            }
        }
    }

}
