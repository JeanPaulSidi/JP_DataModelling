namespace JP_DataModelling.Models
{
    public class Addresses
    {
        public int AddressId { get; set; }

        public string? Address { get; set; }


        public ICollection<Customers> Customer { get; set; }

    }
}
