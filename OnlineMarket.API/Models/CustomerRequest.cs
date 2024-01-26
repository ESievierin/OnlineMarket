namespace OnlineMarket.API.Models
{
    public sealed class CustomerRequest
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string SecondName { get; set; } = null!;

        public byte Age { get; set; }

        public string Email { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;
    }
}
