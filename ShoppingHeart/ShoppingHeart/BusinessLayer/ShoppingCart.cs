using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace ShoppingHeart.BusinessLayer
{
    public class ShoppingCart
    {
        public string CategoryName;
        
        public string ProductName;
        public string ProductImage;
        public string ProductPrice;
        public string ProductDescription;
        public void AddNewCategory()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = DataLayer.DataAccess.AddParameter("@CategoryName", CategoryName, System.Data.SqlDbType.VarChar, 200);
            DataTable dt = DataLayer.DataAccess.ExecuteDTByProcedure("SP_AddNewCategory", parameters);
        }



    }
}