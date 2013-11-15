using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viksi.Models;

namespace Viksi.Data
{
    public interface IViksiData
    {
        IRepository<Broker> Brokers { get; }

        IRepository<Agency> Agencies { get; }

        IRepository<AgencyBosses> AgencyBosses { get; }

        IRepository<Category> Categories { get; }

        IRepository<SubCategory> SubCategories { get; }

        IRepository<Offer> Offers { get; }

        IRepository<Phone> Phones { get; }

        int SaveChanges();
    }
}
