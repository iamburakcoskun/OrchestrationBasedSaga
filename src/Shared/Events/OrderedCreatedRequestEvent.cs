using Shared.Interfaces;

namespace Shared.Events
{
    public class OrderedCreatedRequestEvent : IOrderedCreatedRequestEvent
    {
        public int OrderId { get; set; }

        public string BuyerId { get; set; }

        public List<OrderItemMessage> OrderItems { get; set; } = new List<OrderItemMessage>();

        public PaymentMessage PaymentMessage { get; set; }
    }
}
