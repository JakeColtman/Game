using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Geometry;
using Engine.Player;

namespace Engine.Unit.Custom.Draughts
{
    class Man : IEntity
    {

        IPoint _pos;

        public Man(IPoint pos)
        {
            _pos = pos;
        }

        public IPoint get_pos()
        {
            return _pos;
        }

        public TwoPlayers get_side()
        {
            throw new NotImplementedException();
        }

        public IEntity move_in_direction(Direction direction)
        {
            return new Man(_pos.get_next_point_in_direction(direction));
        }
    }
}
