namespace OnlineMarket.API.Models
{
    public sealed class CustomerRequest
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public byte Age { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}
