using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public interface IHandler
    {
        bool can_handle(IMessage message);
        bool will_allow(IMessage message);
        bool process(IMessage message);
    }
}
