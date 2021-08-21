using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _context;

        public TransferRepository(TransferDbContext context)
        {
            _context = context;
        }

        public void AddTransferLog(TransferLog transferLog)
        {
            _context.TransferLogs.Add(transferLog);
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _context.TransferLogs;
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
