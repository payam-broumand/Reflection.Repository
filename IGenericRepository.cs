using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IGenericRepository<T>
    {
        IEnumerable<T> GetEntities();
        
        string Add(T entity);

        int Remove();
    }
}
