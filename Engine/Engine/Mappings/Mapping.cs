using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mappings
{
    public interface IMapping<T>
    {
        void print();
        T get_pos(ICoordinate coord);
        bool pos_exists(ICoordinate coord);
        bool add_to_pos(T addition, ICoordinate coord);
        bool remove_from_pos(ICoordinate coord);
    }
    

}
