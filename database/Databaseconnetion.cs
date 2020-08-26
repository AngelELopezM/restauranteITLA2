using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace database
{
    public class Databaseconnetion
    {
        public void ExecuteDml(SqlCommand query, SqlConnection connection)
        {

			try
			{
				connection.Open();
				query.ExecuteNonQuery();
				connection.Close();
			}
			catch (Exception)
			{

				
			}
        }

    }
}
