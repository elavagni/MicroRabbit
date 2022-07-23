using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transfertRepository;
        private readonly IEventBus _bus;

        public TransferService(ITransferRepository accountRepository, IEventBus bus)
        {
            _transfertRepository = accountRepository;
            _bus = bus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transfertRepository.GetTransferLogs();
        }       
    }
}
