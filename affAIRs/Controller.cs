using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace affAIRs
{
    
    class Controller
    {
        
        DAL dal;
        public Controller()
        {
            dal = new DAL();
        }

        public SqlDataAdapter GetAllProducts()
        {
            SqlDataAdapter da = dal.GetAllProducts();
            return da;
        }


    }
}
