using System;
using Engine.Player;
using Engine.Unit;
using Engine.Geometry.Coordinates;
using Engine.Geometry;

namespace Draughts
{

    class Man :IEntity
    {
        Coordinate _pos;
        TwoPlayers _side;

        public Man(Coordinate position, TwoPlayers side)
        {
            _pos = position;
            _side = side;
        }

        public IPoint get_pos()
        {
            throw new NotImplementedException();
        }

        public TwoPlayers get_side()
        {
            throw new NotImplementedException();
        }
    }

    struct ManCreationInstruction
    {
        public Coordinate position;
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

            //SquareMap<Iso2D, Man> map = new SquareMap<Iso2D, Man>();
            //ManFactory manFactory = new ManFactory();
            

            //List<ManCreationInstruction> setup = new List<ManCreationInstruction>()
            //{
            //    new ManCreationInstruction() { side = TwoPlayers.white, position = new Iso2DCoord(0,0) },
            //    new ManCreationInstruction() { side = TwoPlayers.white, position = new Iso2DCoord(2,0) },
            //    new ManCreationInstruction() { side = TwoPlayers.black, position = new Iso2DCoord(0,2) },
            //    new ManCreationInstruction() { side = TwoPlayers.black, position = new Iso2DCoord(2,2) },
            //};

            //setup.ForEach(x => map.add_to_coord(x.position, manFactory.create(x)));

            //IEngine engine = new SimpleEngine();
            //engine.add_handler(new SquareMapEventHandler<Iso2D, Man>(map));

            //#region rules

            //IEnumerable<IBlockingRule> menRules = new List<IBlockingRule>()
            //{
            //    new Rules.BlackMenMoveDownBoard(),
            //    new Rules.MenCanOnlyMoveOneSquare(),
            //    new Rules.WhiteMenMoveOnlyUpBoard(),
            //    new Rules.MenCanOnlyMoveDiagonally()
            //};

            //engine.add_rule(new MultiAnd(menRules));

            ////engine.add_blocking_handler(new Rules.Board.PiecesCantMoveOutsideBoard(2));
            //// engine.add_blocking_handler(new Rules.Board.ManMovingIntoOccupiedSquareIsAttack(map));

            //#endregion

            ////Engine.Movement.ICoordinateFactory<Iso2D> coordinateFactory = new Iso2DCoordinateFactory();

            ////MovementRequest<Iso2D> req = new MovementRequest<Iso2D>(coordinateFactory){
            ////        movement = new Iso2DMovement(new Vector<Iso2D>() { d})
            ////        mover = map.get_item_at_coord(new Iso2DCoord(0,0))
            ////    };



            //Engine.Movement.MovementRequest<Iso2D> req = new Engine.Movement.MovementRequest<Iso2D>()
            //    {
            //        end = new Iso2DCoord(1,1),
            //        mover = map.get_item_at_coord(new Iso2DCoord(0,0))
            //    };
            //engine.send_message(req);
            //Console.WriteLine("Made move one");
            //Console.WriteLine(map.get_item_at_coord(new Iso2DCoord(1, 1)).get_side());
            //Engine.Movement.MovementRequest<Iso2D> req2 = new Engine.Movement.MovementRequest<Iso2D>()
            //{
            //    end = new Iso2DCoord(2, 2),
            //    mover = map.get_item_at_coord(new Iso2DCoord(1,1))
            //};


            //   engine.send_message(req2);
            // Console.WriteLine(map.get_item_at_coord(new Iso2DCoord(1, 1)).get_side());

            Console.Read();

        }
    }
}
