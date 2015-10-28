using Engine.Rules;
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
        void add_rule(IBlockingRule rule);
        void add_handler(IHandler handler);
        void commit();
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
        List<IHandler> _handlers;
        List<IBlockingRule> _rules;

        public SimpleEngine()
        {
            _unconfirmed_messages = new List<IMessage>();
            _handlers = new List<IHandler>();
            _rules = new List<IBlockingRule>();
        }

        public void add_rule(IBlockingRule rule)
        {
            _rules.Add(rule);
        }

        public void add_handler(IHandler handler)
        {
            _handlers.Add(handler);
        }

        public void commit()
        {
            _handlers.ForEach(x => x.commit());
        }

        public void rollback()
        {
            _handlers.ForEach(x => x.rollback());
        }

        public void send_message(Message message)
        {
            if (_rules.All(x => x.will_allow(message)))
            {
                Console.WriteLine("Move accepted");
                
                _handlers.ForEach(x => x.pass_message(message));
            }
            else
            {
                Console.WriteLine("Move rejected");
            }
        }
    }
}
