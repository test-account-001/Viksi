namespace Viksi.Models
{
    using System.Collections.Generic;

    public class AgencyBosses
    {
        public int Id { get; set; }

        public Broker Boss { get; set; }

        public virtual ICollection<Agency> Agencies { get; set; }
    }
}