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
        void send_message(Message message);
        void add_blocking_handler(IMessageHandler handler);
        void confirm();
        void rollback();           
    }

    public class UndoMessage :Message
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

    public class SimpleEngine : IEngine
    {

        List<IMessage> _unconfirmed_messages;
        List<IMessageHandler> _handlers;

        public SimpleEngine()
        {
            _unconfirmed_messages = new List<IMessage>();
            _handlers = new List<IMessageHandler>();
        }

        public void add_blocking_handler(IMessageHandler handler)
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

        public void send_message(Message message)
        {
            if (_handlers.All(x => x.will_allow(message)))
            {
                Console.WriteLine("Move accepted");
                
                _handlers.Where(x => x.can_handle(message)).Select(x => x.process(message)).ToList();
            }
            else
            {
                Console.WriteLine("Move rejected");
            }
        }
    }
}
