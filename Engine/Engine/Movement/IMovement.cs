using Engine.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Movement
{

    public interface IMovement
    {
        IEnumerable<Direction> get_directions();
        Tuple<Direction, IMovement> get_direction();
    }

    class Movement : IMovement
    {

        IEnumerable<Direction> _directions;

        public Movement(IEnumerable<Direction> directions)
        {
            _directions = directions;
        }

        public Tuple<Direction, IMovement> get_direction()
        {
            return new Tuple<Direction, IMovement>(_directions.First(), new Movement(_directions.Skip(1)));
        }

        public IEnumerable<Direction> get_directions()
        {
            return _directions;
        }
    }
}
