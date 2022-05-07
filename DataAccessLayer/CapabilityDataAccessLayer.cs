using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CapabilityDataAccessLayer
    {
        public string AddCapabilityToDataBase(Capability capability)
        {
            try
            {
                string connectionString = @"Data Source = DESKTOP-HLM777P ; Initial Catalog = Samarth; Integrated Security  =true ;";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"INSERT INTO Capability Values('" + capability.Summary + "'," + capability.TrackId + ");";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                int row = sqlCommand.ExecuteNonQuery();

                int capId = findCapabilityId(capability);
                int number = capability.Ko.Count();
                int index = 0;
                while (index<number)
                {
                    query = @"Insert into Ko Values (" + capId + ",'" + capability.Ko[index++] + "'); ";
                    sqlCommand = new SqlCommand(query, sqlConnection);

                    row = sqlCommand.ExecuteNonQuery();
                       
                }

                number = capability.NonKo.Count();
                index = 0;
                while (index < number)
                {
                    query = @"Insert into NonKo Values (" + capId + ",'" + capability.NonKo[index++] + "'); ";
                    sqlCommand = new SqlCommand(query, sqlConnection);

                    row = sqlCommand.ExecuteNonQuery();

                }

                return "Successfully Added One Row";

            }
            catch(Exception exception)
            {
                return "Something Went Wrong \n" + exception;
            }
        }

        private int findCapabilityId(Capability capability)
        {

            string connectionString = @"Data Source = DESKTOP-HLM777P ; Initial Catalog = Samarth; Integrated Security  =true ;";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = @"SELECT CapabilityId FROM Capability WHERE Summary ='" + capability.Summary + "' and TrackId=" + capability.TrackId + ";";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read())
            {
                return Convert.ToInt32(reader[0]);
            }

            return -1;


        }
    }
}
