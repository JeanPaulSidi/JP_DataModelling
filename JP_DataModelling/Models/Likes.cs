namespace JP_DataModelling.Models
{
    public class Likes
    {
        public int LikeId { get; set; }

        public string? Like { get; set; }


        public ICollection<CustomersLikes> CustomerLike { get; set; }

    }
}
