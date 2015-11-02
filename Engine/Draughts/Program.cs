using System;
using Engine.Player;
using Engine.Unit;
using Engine.Geometry.Coordinates;
using Engine.Geometry;
using Engine.Maps.Custom;
using Engine.Geometry.Converters.Custom;
using Engine.Unit.Custom.Draughts;

namespace Draughts
{
    public class Program
    {

        public void Main(string[] args)
        {

            DraughtsUnitMap map = new DraughtsUnitMap(new Iso2DConverter());
            IPoint manPoint = new DraughsPoint()
            map.add_to_map(new Man());


            Console.Read();

        }
    }
}
