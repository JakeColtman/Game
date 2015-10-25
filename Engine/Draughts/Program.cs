using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;
using Engine.Mappings.Coordinates;
using Engine.Player;
using Engine.Unit;

namespace Draughts
{

    class Man
    {
        ICoordinate<Iso2D> _pos;
        TwoPlayers _side;

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

    class ManFacotry : IUnitFactory<ManCreationInstruction, Man>
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


        }
    }
}
