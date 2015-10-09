using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mappings
{
    
    public class CoordinateMap : IMapping<ICoordinate>
    {

        ICoordinate[,] mapArray;
        int size;

        public CoordinateMap(int size)
        {
            mapArray = new ICoordinate[size, size];

            for(int ii = 0; ii < size; ii++)
            {
                for(int jj = 0; jj < size; jj++)
                {
                    mapArray[ii, jj] = new Coordinate(ii, jj);
                }
            }

            this.size = size;

        }

        public ICoordinate get_pos(ICoordinate coord)
        {
            return mapArray[coord.get_x_pos(), coord.get_y_pos()];
        }

        public void print()
        {
            Console.WriteLine("I'm a square map of size " + size.ToString());
        }
        
        public bool pos_exists(ICoordinate coord)
        {
            return (coord.get_x_pos() >= 0) && (coord.get_x_pos() < size) && (coord.get_y_pos() >= 0) && (coord.get_y_pos() < size);
        }

        public bool add_to_pos(ICoordinate addition, ICoordinate coord)
        {
            if (pos_exists(coord)) return true;
            return false;
        }

        public bool remove_from_pos(ICoordinate coord)
        {
            return false;
        }
    }
}
