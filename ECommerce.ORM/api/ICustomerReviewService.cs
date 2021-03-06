using ECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.api
{
    public interface ICustomerReviewService<T> : IService<T> where T : CustomerReview
    {
    }
}
