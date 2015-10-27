using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Rules.Composition
{
    namespace Engine.Rules.Composition
    {
        public class Or : IRule
        {

            IMessageHandler _left;
            IMessageHandler _right;

            public Or(IMessageHandler left, IMessageHandler right)
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
