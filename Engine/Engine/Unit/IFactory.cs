using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Unit
{
    public interface IUnitFactory<TInstruction, TOutput>
    {
        TOutput create(TInstruction instruction);
    }
}
