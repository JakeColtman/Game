using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{

    public interface IMessage
    {
        bool execute();
        bool undo();
    }

    public interface IEngine
    {
        void send_message(IMessage message);
        void add_blocking_handler(IHandler handler);
        void confirm();
        void rollback();           
    }

    public class UndoMessage :IMessage
    {

        IMessage _original_message;

        public UndoMessage(IMessage originalMessage)
        {
            _original_message = originalMessage;
        }

        public bool execute()
        {
            return _original_message.undo();
        }

        public bool undo()
        {
            return _original_message.execute();
        }
    }

    class SimpleEngine : IEngine
    {

        List<IMessage> _unconfirmed_messages;
        List<IHandler> _handlers;

        public SimpleEngine()
        {
            _unconfirmed_messages = new List<IMessage>();
        }

        public void add_blocking_handler(IHandler handler)
        {
            _handlers.Add(handler);
        }

        public void confirm()
        {
            _unconfirmed_messages.Clear();
        }

        public void rollback()
        {
            _unconfirmed_messages.Select(x => new UndoMessage(x)).ToList().ForEach(x => send_message(x));
            confirm();
        }

        public void send_message(IMessage message)
        {
            if (_handlers.Where(x => x.can_handle(message)).All(x => x.will_allow(message)))
            {
                _handlers.Select(x => x.process(message));
            }
        }
    }
}
