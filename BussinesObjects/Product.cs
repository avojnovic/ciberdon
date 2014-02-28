using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinesObjects
{
   public class Product
    {
        private Int64 _id;

        public Int64 Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private List<ProductQuantity> _productQuantity;

        public List<ProductQuantity> ProductQuantity
        {
            get { return _productQuantity; }
            set { _productQuantity = value; }
        }
    }
}
