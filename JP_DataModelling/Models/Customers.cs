namespace JP_DataModelling.Models
{
    public class Customers
    {
        public int CustomerId { get; set; }

        public string CustomerFirstName { get; set; }

        public string? CustomerMiddleName { get; set; }

        public string CustomerLastName { get; set; }

        public DateTime CustomerBirthDate { get; set; }

        public string? CustomerEmail { get; set; }



        public ICollection<PhoneNumbers> PhoneNumber { get; set; }

        public int AddressId { get; set; }

        public Addresses Address { get; set; }

        public ICollection<CustomersLikes> CustomerLike { get; set; }

    }
}
