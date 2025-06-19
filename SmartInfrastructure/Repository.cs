using ISmartInfrasture;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SmartInfrastructure
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Repository(BaseDataDbContext Context)
        {
            this.Context = Context;
        }

        public BaseDataDbContext Context { get; }

        public async Task<List<T>> GetAll()
        {
            return await Context.Set<T>().AsNoTracking().ToListAsync();
        }
    }
}
