using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorDocs.Database
{
    public class Service<T>
        where T : class, IIdentify, new()
    {
        private readonly DocsContext context;

        public Service(DocsContext context) => this.context = context;

        public virtual Task<List<T>> GetAll() =>
            context
                .Set<T>()
                .ToListAsync();

        public virtual Task<T> Get(int id) =>
            context
                .Set<T>()
                .FirstOrDefaultAsync(t => t.Id == id);

        public virtual async Task<T> Add(T t)
        {
            context.Set<T>().Add(t);
            await context.SaveChangesAsync();
            return t;
        }

        public virtual async Task<T> Update(T t)
        {
            context.Set<T>().Update(t);
            await context.SaveChangesAsync();
            return t;
        }

        public virtual async Task Delete(int id)
        {
            T t = new T() { Id = id };
            context.Set<T>().Remove(t);
            await context.SaveChangesAsync();
        }
    }
}