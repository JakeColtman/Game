using Engine;
using Engine.Attack;
using Engine.Mappings.Coordinates;
using Engine.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draughts.Rules
{
    //class ManCanJumpToTake
    //{

    //    IEngine _engine;

    //    public ManCanJumpToTake(IEngine engine)
    //    {
    //        _engine = engine;
    //    }

    //    public bool can_handle(Message message)
    //    {
    //        Console.WriteLine("Can square map handler the move?");
    //        return message is MovementRequest<Iso2D>;
    //    }

    //    Iso2DCoord jumped_over_point(MovementRequest<Iso2D> req)
    //    {
    //        return new Iso2DCoord(
    //                (req.mover.get_pos().get_dimension_value(Iso2D.left) + req.end.get_dimension_value(Iso2D.left)) / 2,
    //                (req.mover.get_pos().get_dimension_value(Iso2D.right) + req.end.get_dimension_value(Iso2D.right)) / 2
    //            );
    //    }

    //    public bool process(Message message)
    //    {
    //        var req = (MovementRequest<Iso2D>)message;
    //        _engine.send_message(new DestructionRequest<Iso2D>()
    //        {
    //            position = jumped_over_point(req)
    //        });

    //        return true;     
    //    }

    //    public bool will_allow(Message message)
    //    {
    //        if (!(message is MovementRequest<Iso2D>)) { return true; }

    //        var req = (MovementRequest<Iso2D>)message;

    //        Console.WriteLine("Assessing whether the man is moving diagonally");

    //        int leftMove = Math.Abs(req.end.get_dimension_value(Iso2D.left) - req.mover.get_pos().get_dimension_value(Iso2D.left));
    //        int rightMove = Math.Abs(req.end.get_dimension_value(Iso2D.right) - req.mover.get_pos().get_dimension_value(Iso2D.right));
    //        return leftMove > 0 && rightMove > 0 && leftMove == rightMove;


    //    }
    //}
}
