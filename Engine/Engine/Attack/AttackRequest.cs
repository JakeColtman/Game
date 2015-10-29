using Engine.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Attack
{
    public class AttackRequest<T> : Message
    {
        public IEntity attacker;
        public IEntity attacked;
    }
}