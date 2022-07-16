using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;
        void Publish<T>(T @event) where T : Event;
        /// <summary>
        /// Subscribe to generic event
        /// </summary>
        /// <typeparam name="T">Type of Event</typeparam>
        /// <typeparam name="TH">Event Handler</typeparam>
        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
