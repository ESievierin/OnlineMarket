namespace OnlineMarket.BLL.DTO
{
    public sealed class CustomerDTO
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

<<<<<<< Updated upstream
        public string LastName { get; set; } = null!;
=======
        public string SecondName { get; set; } = null!;
>>>>>>> Stashed changes

        public byte Age { get; set; }

        public string Email { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;
    }
}
