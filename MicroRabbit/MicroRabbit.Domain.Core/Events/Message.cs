using MediatR;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        public string MessgaeType { get; protected set; }

        protected Message()
        {
            MessgaeType = GetType().Name;
        }
    }
}
