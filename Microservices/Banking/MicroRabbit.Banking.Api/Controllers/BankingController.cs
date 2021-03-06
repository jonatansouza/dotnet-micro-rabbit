using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Api.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase {
        private readonly IAccountService service;

        public BankingController(IAccountService service) {
            this.service = service;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get() {
            return Ok(service.GetAccounts());
        }
        [HttpPost]
        public IActionResult Post([FromBody] AccountTransfer accountTransfer) {
            service.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}
