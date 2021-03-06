using Carrot.Fallback;
using RabbitMQ.Client.Events;

namespace Carrot.Messages
{
    public class CorruptedMessage : NonConsumableMessage
    {
        internal CorruptedMessage(BasicDeliverEventArgs args)
            : base(args) 
        {
        }

        protected override ConsumingFailureBase Result(IFallbackStrategy fallbackStrategy)
        {
            return new CorruptedMessageConsumingFailure(this, fallbackStrategy);
        }
    }
}