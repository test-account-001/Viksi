namespace Viksi.Models
{
    public class Offer
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string Description { get; set; }

        public int BrokerId { get; set; }

        public virtual Broker Broker { get; set; }
    }
}