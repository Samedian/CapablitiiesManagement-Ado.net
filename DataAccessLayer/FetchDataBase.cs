using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FetchDataBase
    {

        public List<Capability> Fetch(string trackName)
        {
            Capability capability = new Capability();
            List<Capability> capabilities = new List<Capability>();
            List<string> Ko = new List<string>();
            List<string> NonKo = new List<string>();

            try
            {
                string connectionString = @"Data Source = DESKTOP-HLM777P ; Initial Catalog = Samarth; Integrated Security  =true ;";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = "Select C.CapabilityId, C.TrackId, C.Summary FROM Capability C inner join Track T on C.TrackId = T.TrackId and T.TrackName ='" + trackName + "';";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while(reader.Read())
                {
                    capability.CapabilityId = Convert.ToInt32(reader[0]);
                    capability.TrackId = Convert.ToInt32(reader[1]);
                    capability.Summary = reader[2].ToString();


                }

                sqlConnection.Close();
                sqlConnection.Open();
                query = "Select Kos from Ko where CapabilityId =" + capability.CapabilityId + ";";


                sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataReader read = sqlCommand.ExecuteReader();

                while (read.Read())
                {

                    Ko.Add(read[0].ToString());
                }

                sqlConnection.Close();
                sqlConnection.Open();

                capability.Ko = Ko;

                query = "Select NonKos from NonKo where CapabilityId =" + capability.CapabilityId + ";";


                sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataReader readNonKo = sqlCommand.ExecuteReader();

                while (readNonKo.Read())
                {

                    NonKo.Add(readNonKo[0].ToString());
                }
                capability.NonKo = NonKo;

                sqlConnection.Close();

                capabilities.Add(capability);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return capabilities;
        }
    }
}
