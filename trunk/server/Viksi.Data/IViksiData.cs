namespace Viksi.Data
{
    using Viksi.Models;

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