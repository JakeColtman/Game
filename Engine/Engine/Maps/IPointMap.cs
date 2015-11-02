using Engine.Geometry;
using Engine.Geometry.Coordinates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Maps
{

    public interface IMapReader<T>
    {
        //Implementing this you'll probably want to inject something to parse the coordinates into the right form
        T get_from_coordinate(Coordinate coord); 
    } 
    
    public interface IMapUpdater<T>
    {
        bool add_to_map(Coordinate coord, T addition);
        bool remove_from_map(Coordinate coord);
    }
     

}
