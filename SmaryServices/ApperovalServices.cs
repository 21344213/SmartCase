using ISmartInfrasture;
using ISmartServices;
using SmartDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartServices
{
    public class ApperovalServices : IApperovalServices
    {
        public ApperovalServices(IRepository<Apperoal> repository)
        {
            Repository = repository;
        }

        public IRepository<Apperoal> Repository { get; }

        public async Task<List<Apperoal>> GetAll()
        {
            return await Repository.GetAll();
        }
    }
}
