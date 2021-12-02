using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.api
{
    public interface IService<T>
    {
        List<T> Select();
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);


    }

}
