using MicroRabbit.Transfer.Api.Controllers;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Dtos;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Transfer.Api.Controllers
{
    public class TransferController : BaseApiController
    {
        private readonly ITransferServices _transferService;

        public TransferController(ITransferServices transferService)
        {
            _transferService = transferService;
        }

        [HttpGet("get-transfer-logs")]
        public ActionResult<TransferLog> GetTransferLogsAction()
        {
            return Ok(_transferService.GetTransferLogs());
        }

        [HttpPost("add-transfer-log")]
        public ActionResult<TransferLog> AddTransferLogAction([FromBody]TransferLogDto transferLogDto)
        {
            var transferLog = new TransferLog
            {
                FromAccount = transferLogDto.FromAccount,
                ToAccount = transferLogDto.ToAccount,
                TransferAmount = transferLogDto.TransferAmount
            };

            _transferService.AddTransferLog(transferLog);

            if(_transferService.SaveChanges()) return Ok(transferLog);

            return BadRequest("Failed To Add TransferLog");
        }

        //[HttpGet("get-transfer-logs")]
        //public ActionResult<TransferLog> GetTransferLogsAction()
        //{
        //    return Ok(_transferService.GetTransferLogs());
        //}
    }
}
