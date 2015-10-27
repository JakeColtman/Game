using Engine.Mappings.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Attack
{
    public class DestructionRequest<T> : Message
    {
        public ICoordinate<T> position;
    }
}