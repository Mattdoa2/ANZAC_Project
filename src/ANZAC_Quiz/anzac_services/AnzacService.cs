using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace anzac_services
{
    public class AnzacService: IAnzacService
    {
        public string GetMessage(string name) 
        {
            return "The web service is speaking to you";
        }

        public string FindAnzac(string queryString) 
        {
            SqlConnection conn = new SqlConnection();
            DataSet dSet = new DataSet();
            SqlDataAdapter adapt = new SqlDataAdapter();
            SqlCommand sqlCmd = new SqlCommand("");

            return "www.google.com";
        }
    }
}
