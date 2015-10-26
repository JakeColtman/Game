using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public interface IMessageHandler
    {
        bool can_handle(Message message);
        bool will_allow(Message message);
        bool process(Message message);
    }
    
}
