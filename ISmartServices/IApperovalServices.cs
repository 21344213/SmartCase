using SmartDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISmartServices
{
    public interface IApperovalServices
    {
        Task<List<Apperoal>> GetAll();
    }
}
