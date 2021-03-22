using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UNIM.Components.CommandHandlers;
using UNIM.Domain;
using UNIM.Domain.Commands;

namespace UNIM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IRequestClient<ISubmitOrderCommand> _submitOrderRequestClient;

        public OrderController(ILogger<OrderController> logger, IRequestClient<ISubmitOrderCommand> submitOrderRequestClient)
        {
            _logger = logger;
            _submitOrderRequestClient = submitOrderRequestClient;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Guid id, string customerNumber) {

            var response = await _submitOrderRequestClient.GetResponse<IOrderSubmissionAccepted>(new
            {
                OrderId = id,
                Timestamp = InVar.Timestamp,
                CustomerNumber = default(string)
            });

            return Ok(response.Message);
        }
    }
}
