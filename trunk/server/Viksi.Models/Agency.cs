namespace Viksi.Models
{
    using System.Collections.Generic;

    public class Agency
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }

        public string WebSite { get; set; }

        public string Email { get; set; }

        public virtual ICollection<Broker> Brokers { get; set; }

        public Agency()
        {
            this.Phones = new HashSet<Phone>();
            this.Brokers = new HashSet<Broker>();
        }
    }
}