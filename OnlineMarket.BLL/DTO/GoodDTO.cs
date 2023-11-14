namespace OnlineMarket.BLL.DTO
{
    public sealed class GoodDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public bool IsАvailable { get; set; }

        public decimal Price { get; set; }
    }
}
