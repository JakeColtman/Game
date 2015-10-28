using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Geometry
{
    public interface IPoint
    {
        IPoint get_next_point_in_direction(Direction direction);
    }

}
