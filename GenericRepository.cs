using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GenericRepository<T> : IGenericRepository<T>
    {
        public string Add(T entity)
        {
            System.Windows.Forms.MessageBox.Show(entity.ToString());
            return entity.ToString();
        }

        public IEnumerable<T> GetEntities()
        {
            throw new NotImplementedException();
        }

        public int Remove()
        {
            throw new NotImplementedException();
        }
    }
}
