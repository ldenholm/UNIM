using System;
using System.Collections.Generic;
using System.Text;

namespace UNIM.Domain.Commands
{
    public interface IOrderSubmissionAccepted
    {
        public Guid OrderId { get; set; }
        public DateTime Timestamp { get; set; }
        public string CustomerNumber { get; set; }
    }
}
