using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TrackDataAccessLayer
    {
        
        public string AddTrackToDataBase(Track track) 
        {
            try
            {
                string connectionString = @"Data Source = DESKTOP-HLM777P ;Initial Catalog = Samarth ;Integrated security = true ";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = "INSERT INTO Track Values (" + track.TrackId + ",'" + track.TrackName + "');";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                int rows = sqlCommand.ExecuteNonQuery();

                return "Successfully Added One Row";
            }catch(Exception exception)
            {
                return "Something Went Wrong \n" + exception;
            }

        }
    }
}
