using System;
using Engine.Player;
using Engine.Unit;
using Engine.Geometry.Coordinates;
using Engine.Geometry;
using Engine.Maps.Custom;
using Engine.Geometry.Converters.Custom;
using Engine.Unit.Custom.Draughts;
using Engine.Geometry.Points.Custom;
using Engine.Geometry.Coordinates.Default;

namespace Draughts
{
    public class Program
    {

        public void Main(string[] args)
        {

            DraughtsUnitMap map = new DraughtsUnitMap(new Iso2DConverter());
            IPoint manPoint = new DraughtsPoint(0, 0);
            map.add_to_map(new IsometricCood(0,0), new Man(manPoint));

            map.get_from_coordinate(new IsometricCood(0, 0)).move_in_direction(;


            Console.Read();

        }
    }
}
