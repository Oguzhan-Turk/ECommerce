﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Entity;

namespace ECommerce.Service.api
{
   public interface ISellerService<T> : IUserService<T> where T : Seller
    {
    }
}
