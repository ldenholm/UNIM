using System;

namespace UNIM.Domain
{
    public interface ISubmitOrderCommand
    {
        public Guid OrderId { get; set; }
        public DateTime Timestamp { get; set; }
        public string CustomerNumber { get; set; }
    }
}
