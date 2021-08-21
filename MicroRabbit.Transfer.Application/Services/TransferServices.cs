using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferServices : ITransferServices
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;

        public TransferServices(ITransferRepository transferRepository, IEventBus bus)
        {
            _transferRepository = transferRepository;
            _bus = bus;
        }

        public void AddTransferLog(TransferLog transferLog)
        {
            _transferRepository.AddTransferLog(transferLog);
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }

        public bool SaveChanges()
        {
            return _transferRepository.SaveChanges();
        }
    }
}
