using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viksi.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext Context { get; set; }

        protected IDbSet<T> DbSet { get; set; }

        public Repository()
            : this(new ViksiDbContext())
        {
        }

        public Repository(ViksiDbContext context)
        {
            this.Context = context;
            this.DbSet = this.Context.Set<T>();
        }

        public IQueryable<T> All()
        {
            return this.DbSet.AsQueryable();
        }

        public void Add(T entity)
        {
            DbEntityEntry entry = this.Context.Entry(entity);
            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.DbSet.Add(entity);
            }
        }

        public void Delete(T entity)
        {
            DbEntityEntry entry = this.Context.Entry(entity);
            if (entry.State != EntityState.Deleted)
            {
                entry.State = EntityState.Deleted;
            }
            else
            {
                this.DbSet.Attach(entity);
                this.DbSet.Remove(entity);
            }
        }

        public void Update(T entity)
        {
            DbEntityEntry entry = this.Context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.DbSet.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        public void Detach(T entity)
        {
            DbEntityEntry entry = this.Context.Entry(entity);

            entry.State = EntityState.Detached;
        }
    }
}
