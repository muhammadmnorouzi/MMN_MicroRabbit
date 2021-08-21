using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Application.Interfaces
{
    public interface ITransferServices
    {
        IEnumerable<TransferLog> GetTransferLogs();
        void AddTransferLog(TransferLog transferLog);
        bool SaveChanges();
    }
}
