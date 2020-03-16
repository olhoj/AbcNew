using Abc.Data.Common;
using Abc.Data.Quantity;
using Abc.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Abc.Infra
{
    public abstract class FilteredRepository<TDomain, TData> : SortedRepository<TDomain, TData>, ISearching
        where TData : PeriodData, new()
        where TDomain : Entity<TData>, new()

    {
        public string SearchString { get; set; }
        protected FilteredRepository(DbContext c, DbSet<TData> s) : base(c, s) { }

        protected internal override IQueryable<TData> createSqlQuery()
        {
            var query = base.createSqlQuery();

            query = addFiltering(query);
            return query;
        }

        internal IQueryable<TData> addFiltering(IQueryable<TData> query)
        {
            if (string.IsNullOrEmpty(SearchString)) return query;

            var expression = createWhereExpression();
            return query.Where(expression);
        }

        internal Expression<Func<TData, bool>> createWhereExpression()
        {
            var param = Expression.Parameter(typeof(TData));

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
