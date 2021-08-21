using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
        void AddTransferLog(TransferLog transferLog);
        bool SaveChanges();
    }
}
