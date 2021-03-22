using MassTransit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UNIM.Domain;
using UNIM.Domain.Commands;

namespace UNIM.Components.CommandHandlers
{
    public class SubmitOrderConsumer : IConsumer<ISubmitOrderCommand>
    {
        public async Task Consume(ConsumeContext<ISubmitOrderCommand> context)
        {
            await context.RespondAsync<IOrderSubmissionAccepted>(new { InVar.Timestamp });
        }
    }
}
