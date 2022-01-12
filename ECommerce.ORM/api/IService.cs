using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.api
{
    public interface IService<T>
    {
        List<T> Find();
        T FindById(int id);
        bool Insert(T entity);
        bool Update(int id);
        bool Delete(int id);
    }

}
