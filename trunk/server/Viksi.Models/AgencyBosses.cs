using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viksi.Models
{
    public class AgencyBosses
    {
        public int Id { get; set; }

        public Broker Boss { get; set; }

        public virtual ICollection<Agency> Agencies { get; set; }
    }
}
