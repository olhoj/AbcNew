using Abc.Data.Common;
using Abc.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Abc.Infra
{
    public abstract class FilteredRepository<TDomain, TData> : SortedRepository<TDomain, TData>, IFiltering
        where TData : PeriodData, new()
        where TDomain : Entity<TData>, new()

    {
        public string SearchString { get; set; }
        public string FixedFilter { get ; set ; }
        public string FixedValue { get ; set ; }

        protected FilteredRepository(DbContext c, DbSet<TData> s) : base(c, s) { }

        protected internal override IQueryable<TData> createSqlQuery()
        {
            var query = base.createSqlQuery();
            query = addFixedFiltering(query);
            query = addFiltering(query);
            return query;
        }

        internal IQueryable<TData> addFixedFiltering(IQueryable<TData> query)
        {
            var expression = createFixedWhereExpression();
            return expression is null ? query: query.Where(expression);
        }

        internal Expression<Func<TData, bool>> createFixedWhereExpression()
        {
            if (FixedFilter is null) return null;
            if (FixedValue is null) return null;
            var param = Expression.Parameter(typeof(TData), "s");
            var p = typeof(TData).GetProperty(FixedFilter);

            if (p is null) return null;
            Expression body = Expression.Property(param, p);
            if (p.PropertyType != typeof(string))
                body = Expression.Call(body, "ToString", null);
            body = Expression.Call(body, "Contains", null, Expression.Constant(FixedValue));
            var predicate = body;
         
            return Expression.Lambda<Func<TData, bool>>(predicate, param);
        }

        internal IQueryable<TData> addFiltering(IQueryable<TData> query)
        {
            if (string.IsNullOrEmpty(SearchString)) return query;
            var expression = createWhereExpression();

            return query.Where(expression);
        }

        internal Expression<Func<TData, bool>> createWhereExpression()
        {
            var param = Expression.Parameter(typeof(TData), "s" );

            Expression predicate = null;

            foreach(var p in typeof(TData).GetProperties()) 
            {

            Expression body = Expression.Property(param, p);
                if (p.PropertyType != typeof(string))
                body = Expression.Call(body, "ToString", null);
                body = Expression.Call(body, "Contains", null, Expression.Constant(SearchString));
                predicate = predicate is null ? body : Expression.Or(predicate, body);

            }
            return predicate is null ? null : Expression.Lambda<Func<TData, bool>>(predicate, param);
        }
    }        
    
}
