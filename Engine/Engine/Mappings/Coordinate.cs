using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mappings
{
    public interface ICoordinate
    {
        int get_x_pos();
        int get_y_pos();
    }

    public class Coordinate : ICoordinate
    {

        int x;
        int y;

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int get_x_pos()
        {
            return x;
        }
        public int get_y_pos()
        {
            return y;
        }
    }
}
