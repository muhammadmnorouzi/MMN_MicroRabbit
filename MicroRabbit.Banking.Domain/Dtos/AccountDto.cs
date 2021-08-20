using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Dtos
{
    public class AccountDto
    {
        public string AccountType { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
