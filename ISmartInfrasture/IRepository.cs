using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISmartInfrasture
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll();

        Task<bool> AddAsync(T t);
    }
}
