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
        ICoordinate<T> get_next(Vector<T> vector);
        
    }

    public enum Direction { forward = 1, backwards = -1 }

    public struct Vector<T>
    {
        public T _dimension;
        public Direction _direction;
    }

   

}
