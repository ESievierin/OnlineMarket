namespace OnlineMarket.DAL.Entities
{
    public sealed class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public DateTimeOffset OrderDate { get; set; }

        public DateTimeOffset CompletionDate { get; set; }

        public Customer Customer { get; set; } = null!;
    }
}
