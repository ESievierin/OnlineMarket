namespace OnlineMarket.API.Models
{
    public sealed class GoodRequest
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsAvailable { get; set; }

        public decimal Price { get; set; }
    }
}
