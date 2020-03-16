using Abc.Data.Common;
using Abc.Domain.Common;
using Abc.Domain.Quantity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Infra
{
    public abstract class BaseRepository<TDomain,TData> : ICrudMethods<TDomain> 
        where TData: PeriodData, new()
        where TDomain:Entity<TData>,new()
    {

        protected internal DbContext db;

        protected internal DbSet<TData> dbSet;

        protected BaseRepository(DbContext c, DbSet<TData> s)
        {
            db = c;
            dbSet = s;
        }
        public virtual async Task<List<TDomain>> Get()
        {
            var query = createSqlQuery();
            var set = await runSqlQueryAsync(query);
            return toDomainObjectsList(set);
        }

        internal List<TDomain> toDomainObjectsList(List<TData> set)=> set.Select(toDomainObject).ToList();

        
        protected internal abstract TDomain toDomainObject(TData periodData);
        

        internal async Task<List<TData>> runSqlQueryAsync(IQueryable<TData> query)=>await query.AsNoTracking().ToListAsync();
        

        protected internal virtual IQueryable<TData> createSqlQuery()
        {
            var query = from s in dbSet select s;
            return query;
        }

        public async Task<TDomain> Get(string id)
        {
            if (id is null) return new TDomain();
            var d = await getData(id);
            var obj= new TDomain { Data = d };            
            return obj;
        }

        protected abstract Task<TData> getData(string id);

        public async Task Add(TDomain obj)
        {
            dbSet.Add(obj.Data);
            await db.SaveChangesAsync();
        }

        public async Task Delete(string id)
        {
            var d = await dbSet.FindAsync(id);

            if (d is null) return;
            dbSet.Remove(d);
            await db.SaveChangesAsync();

        }
        
        public async Task Update(TDomain obj)
        {
            db.Attach(obj.Data).State = EntityState.Modified;

            //var d = await db.Measures.FirstOrDefaultAsync(x => x.Id == obj.Data.Id);
            //d.Code = obj.Data.Code;
            //d.Name = obj.Data.Name;
            //d.Definition = obj.Data.Definition;
            //d.ValidFrom = obj.Data.ValidFrom;
            //d.ValidTo = obj.Data.ValidTo;
            //db.Measures.Update(d);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!MeasureViewExists(MeasureView.Id))
                //{
                //    return NotFound();
                //}
                //else
                //{
                throw;
            }
        }
    }
}
