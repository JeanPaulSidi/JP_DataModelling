namespace JP_DataModelling.Models
{
    public class PhoneNumbers
    {
        public int PhoneNumberId { get; set; }

        public string? PhoneNumber { get; set; }


        public int CustomerId { get; set; }
        public Customers Customer { get; set; }

    }
}
