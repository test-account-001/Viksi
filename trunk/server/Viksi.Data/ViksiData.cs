namespace Viksi.Data
{
    using System;
    using System.Collections.Generic;

    public class ViksiData : IViksiData
    {
        private readonly ViksiDbContext context;

        private readonly IDictionary<Type, object> repos;

        public ViksiData()
            : this(new ViksiDbContext())
        { }

        public ViksiData(ViksiDbContext context)
        {
            this.context = context;
            this.repos = new Dictionary<Type, object>();
        }

        public IRepository<Models.Broker> Brokers
        {
            get { throw new NotImplementedException(); }
        }

        public IRepository<Models.Agency> Agencies
        {
            get { throw new NotImplementedException(); }
        }

        public IRepository<Models.AgencyBosses> AgencyBosses
        {
            get { throw new NotImplementedException(); }
        }

        public IRepository<Models.Category> Categories
        {
            get { throw new NotImplementedException(); }
        }

        public IRepository<Models.SubCategory> SubCategories
        {
            get { throw new NotImplementedException(); }
        }

        public IRepository<Models.Offer> Offers
        {
            get { throw new NotImplementedException(); }
        }

        public IRepository<Models.Phone> Phones
        {
            get { throw new NotImplementedException(); }
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}