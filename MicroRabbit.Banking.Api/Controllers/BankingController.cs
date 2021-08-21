using MicroRabbit.Banking.Api.Dtos;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Api.Controllers
{
    public class BankingController : BaseApiController
    {
        private readonly IAccountServices _accountServices;

        public BankingController(IAccountServices accountServices)
        {
            _accountServices = accountServices;
        }

        [HttpGet("get-accounts")]
        public ActionResult<IEnumerable<Account>> GetAccountsAction()
        {
            return Ok(_accountServices.GetAccounts());
        }

        //this is written for test and seeding data using api //
        [HttpPost("add-account")]
        public ActionResult<Account> AddAccountAction([FromBody] AccountDto accountDto)
        {
            var account = new Account { AccountType = accountDto.AccountType, AccountBalance = accountDto.AccountBalance };
            _accountServices.AddAccount(account);

            if (_accountServices.SaveChanges()) return Ok(account);

            return BadRequest("Failed to add new account");
        }

        [HttpPost("account-transfer")]
        public IActionResult AccountTransferAction([FromBody] AccountTransfer accountTransfer)
        {
            _accountServices.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}
