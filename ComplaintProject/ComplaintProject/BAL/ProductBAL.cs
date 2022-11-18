using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ComplaintProject.BAL
{
    public class ProductBAL
    {
        DAL.ProductDAL objdeptdl = new DAL.ProductDAL();

        private string _product;
        public string _productid;
        public string product
        {
            get
            {
                return _product;
            }
            set
            {
                _product= value;
            }
        }

        public string productid
        {
            get
            {
                return _productid;
            }
            set
            {
                _productid = value;
            }
        }

        public int insertProduct()
        {
            return objdeptdl.insert_Product(this);
        }

        public DataTable viewProduct()
        {
            return objdeptdl.view_Product();
        }

        public int updateProduct()
        {
            return objdeptdl.Update_Product(this);
        }
        public int deleteProduct()
        {
            return objdeptdl.Delete_Product(this);
        }
    }
}