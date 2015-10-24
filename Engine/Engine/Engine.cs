using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{

    interface IBus <T>
    {
        void send_message(T message);
        void confirm();
        void rollback();           
    }

    interface IStateConfirmer
    {
        void confirm();
        void rollback();
    }

    public interface IEngine
    {
        void send_attack();
        void send_movement();
    }


    class Engine<TwoD> //: IStateConfirmer
    {

        Movement.IMovementBus<TwoD> _movement_bus;
        int _attack_bus;

    }
}
