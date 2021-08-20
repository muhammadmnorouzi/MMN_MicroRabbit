using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Api.Controllers
{
    public class BankingController:BaseApiController
    {
        private readonly IAccountServices _accountServices;

        public BankingController(IAccountServices accountServices)
        {
            _accountServices = accountServices;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountServices.GetAccounts());
        }

    }
}
