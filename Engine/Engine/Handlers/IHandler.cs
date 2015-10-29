using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public interface IHandler
    {
        bool pass_message(Message message);
        bool commit();
        bool rollback();
    }
    
}
