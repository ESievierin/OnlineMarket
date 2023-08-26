using System.ComponentModel.DataAnnotations;

namespace OnlineMarket.DAL.Entities
{
    public sealed  class Good
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; } = null!;

        public bool IsАvailable { get; set; }

        public decimal Price { get; set; }      
    }
}
