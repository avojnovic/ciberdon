using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesObjects;

namespace ControlObjects
{
   public static class ProductManager
    {
       public static IEnumerable<Product> Get()
       {
           CiberdonDbContext dbContext = new CiberdonDbContext();

           var res = from u in dbContext.Product.Include("ProductQuantity")
                     select u;

           return res.ToList();
       }

    }
}
