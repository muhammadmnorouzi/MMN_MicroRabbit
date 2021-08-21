using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}
