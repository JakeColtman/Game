using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mappings.Coordinates
{
    public interface ICoordinate<T>
    {
        int get_pos(T dimension);
        ICoordinate<T> increment(T dimension, direction direction);
    }

   

}
