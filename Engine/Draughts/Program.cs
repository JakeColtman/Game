using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;
using Engine.Mappings.Coordinates;

namespace Draughts
{

    class Man
    {
        ICoordinate<Iso2D> _pos;

        public Man(ICoordinate<Iso2D> position)
        {
            _pos = position;
        }
    }

    class ManFacotry : IUnitFactory<>
    {

    }

    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
