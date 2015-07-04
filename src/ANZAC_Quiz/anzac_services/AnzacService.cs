using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

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
            SqlCommand sqlCmd = new SqlCommand("select profile_url where civil_ocupation=BLACKSMITH");

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["AnzacDbConnection"].ToString();

            conn.Open();
            sqlCmd.Connection = conn;
            adapt.SelectCommand = sqlCmd;
            adapt.Fill(dSet);

            string result = dSet.Tables[0].Rows[0]["profile_url"].ToString();

            return result;
        }
    }
}
