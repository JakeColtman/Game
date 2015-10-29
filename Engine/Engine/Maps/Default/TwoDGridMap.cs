using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Geometry;
using Engine.Geometry.Coordinates;
using Engine.Geometry.Coordinates.Default;

namespace Engine.Maps
{
    class TwoDGridMap : IMapReader<IPoint>
    {
        // Simple infinitely extendable 2D grid of points.  Will provide multiple different objects if asked for the same point 

        public IPoint get_from_coordinate(Coordinate coord)
        {
            if (!(coord is TwoDGridCoord)) throw new NotImplementedException("Only TwoD grid coords are supported by the map");

            var req = coord as TwoDGridCoord;

            return new TwoDSquareGridPoint(req.get_x_value(), req.get_y_value());
        }


    }
}
