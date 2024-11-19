namespace JP_DataModelling.Models
{
    public class CustomersLikes
    {
        public int CustomerId { get; set; }
        public int LikeId { get; set; }
        public Customers Customer { get; set; }
        public Likes Like { get; set; }

    }
}
