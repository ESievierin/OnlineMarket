using System.ComponentModel.DataAnnotations;

namespace OnlineMarket.DAL.Entities
{
    public sealed class Customer
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public string FirstName { get; set; } = null!;

        [MaxLength(20)]
        public string SecondName { get; set; } = null!;

        public byte Age { get; set; }

        [MaxLength(30)]
        public string Email { get; set; } = null!;

        [MaxLength(20)]
        public string PhoneNumber { get; set; } = null!;

        public ICollection<Order> Orders { get; set; }
    }
}
