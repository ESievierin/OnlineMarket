namespace OnlineMarket.API.Models
{
    public class OrderRequest
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int[] GoodsId { get; set; }

        public DateTimeOffset OrderDate { get; set; }

        public DateTimeOffset CompletionDate { get; set; }
    }
}
