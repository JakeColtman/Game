using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;
using Engine.Mappings.Coordinates;
using Engine.Player;
using Engine.Unit;
using Engine.Mappings;

namespace Draughts
{

    class Man
    {
        public ICoordinate<Iso2D> _pos;
        public TwoPlayers _side;

        public Man(ICoordinate<Iso2D> position, TwoPlayers side)
        {
            _pos = position;
            _side = side;
        }
    }

    struct ManCreationInstruction
    {
        public ICoordinate<Iso2D> position;
        public TwoPlayers side;
    }

    class ManFactory : IUnitFactory<ManCreationInstruction, Man>
    {
        public Man create(ManCreationInstruction instruction)
        {
            return new Man(instruction.position, instruction.side);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            SquareMap<Iso2D, Man> map = new SquareMap<Iso2D, Man>();
            ManFactory manFactory = new ManFactory();
            

            List<ManCreationInstruction> setup = new List<ManCreationInstruction>()
            {
                new ManCreationInstruction() { side = TwoPlayers.white, position = new Iso2DCoord(0,0) },
                new ManCreationInstruction() { side = TwoPlayers.white, position = new Iso2DCoord(2,0) },
                new ManCreationInstruction() { side = TwoPlayers.black, position = new Iso2DCoord(0,2) },
                new ManCreationInstruction() { side = TwoPlayers.black, position = new Iso2DCoord(2,2) },
            };

            setup.ForEach(x => map.add_to_coord(x.position, manFactory.create(x)));
            Console.WriteLine("Set up");
            Console.Write(map.get_item_at_coord(new Iso2DCoord(2,0))._side);

            Console.Read();

        }
    }
}
