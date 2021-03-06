﻿namespace Viksi.Data
{
    using System.Data.Entity;
    using Viksi.Models;

    public class ViksiDbContext : DbContext
    {
        public ViksiDbContext()
            : base("ViksiContext")
        {
        }

        public IDbSet<Broker> Brokers { get; set; }

        public IDbSet<AgencyBosses> AgencyBosses { get; set; }

        public IDbSet<Phone> Phones { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Offer> Offers { get; set; }

        public IDbSet<SubCategory> SubCategory { get; set; }
    }
}