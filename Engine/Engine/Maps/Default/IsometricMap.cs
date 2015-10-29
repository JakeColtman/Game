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
    class IsometricMap : IMapReader<IPoint>
    {
        // Simple infinitely extendable 2D grid of points.  Will provide multiple different objects if asked for the same point 
        //Add some DI here to handle multiple types of coords

        public IPoint get_point_by_coordinate(Coordinate coord)
        {
            if (!(coord is IsometricCood)) throw new NotImplementedException("Only TwoD grid coords are supported by the map");

            var req = coord as IsometricCood;

            return new IsometricPoint(req.get_left_value(), req.get_right_value());

        }

    }
}
