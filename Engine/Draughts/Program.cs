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
using Engine.Movement;
using Engine.Rules.Composition;

namespace Draughts
{

    class Man :IEntity<Iso2D>
    {
        ICoordinate<Iso2D> _pos;
        TwoPlayers _side;

        public Man(ICoordinate<Iso2D> position, TwoPlayers side)
        {
            _pos = position;
            _side = side;
        }

        public TwoPlayers get_side()
        {
            return _side;
        }

        ICoordinate<Iso2D> IEntity<Iso2D>.get_pos()
        {
            return _pos;
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

            IEngine engine = new SimpleEngine();
            engine.add_blocking_handler(new SquareMapEventHandler<Iso2D, Man>(map));

            IEnumerable<IMessageHandler> menRules = new List<IMessageHandler>()
            {
                new Rules.BlackMenMoveDownBoard(),
                new Rules.MenCanOnlyMoveOneSquare(),
                new Rules.WhiteMenMoveOnlyUpBoard(),
                new Rules.MenCanOnlyMoveDiagonally()
            };

            engine.add_blocking_handler(new MultiAnd(menRules));

            Engine.Movement.MovementRequest<Iso2D> req = new Engine.Movement.MovementRequest<Iso2D>()
                {
                    end = new Iso2DCoord(2, 1),
                    mover = map.get_item_at_coord(new Iso2DCoord(2,2))
                };

            engine.send_message(req);

            Console.Read();

        }
    }
}
