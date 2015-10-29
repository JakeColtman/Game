using Engine.Geometry;
using Engine.Geometry.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Maps
{

    public interface IPointMapReader
    {
        //Implementing this you'll probably want to inject something to parse the coordinates into the right form
        IPoint get_point_by_coordinate(Coordinate coord); 
    }  

}
