namespace Viksi.Models
{
    public class Phone
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public int BrokerId { get; set; }

        public virtual Broker Broker { get; set; }

        public int AgencyId { get; set; }

        public virtual Agency Agency { get; set; }
    }
}