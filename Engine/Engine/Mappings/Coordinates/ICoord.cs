using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mappings.Coordinates
{
    public interface ICoordinate<TwoD>
    {
        int get_pos(TwoD dimension);
    }

   

}
