using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
// TJENARE DETTA ÄR TEST
namespace affAIRs
{
    class DAL

        //Test kl 15.11

    {
        SqlConnection con = new SqlConnection("Data Source=MAX-DATOR;Initial Catalog=affAIRs;Integrated Security=True");
        

        public void ExecuteUpdate(string sqlQuery)
        {
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public SqlDataAdapter GetAllProducts()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select productNr, productName, productOutPrice from product";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            return da;
        }
    

    }
}
