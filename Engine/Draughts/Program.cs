using System;
using Engine.Player;
using Engine.Unit;
using Engine.Geometry.Coordinates;
using Engine.Geometry;
using Engine.Maps.Custom;
using Engine.Geometry.Converters;
namespace Draughts
{
    public class Program
    {

        public void Main(string[] args)
        {

            DraughtsUnitMap map = new DraughtsUnitMap(new IsometricConverter);


            Console.Read();

        }
    }
}
