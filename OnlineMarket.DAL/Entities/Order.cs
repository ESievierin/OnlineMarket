namespace OnlineMarket.DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public DateTimeOffset OrderDate { get; set; }

        public DateTimeOffset CompletionDate { get; set; }

        public Customer Customer { get; set; } = null!;
    }
}
