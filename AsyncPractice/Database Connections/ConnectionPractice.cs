using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AsyncPractice.Database_Connections
{
    class ConnectionPractice
    {

        public static void Main(String[] args) {
            
            Console.WriteLine("Please enter the connection string for your data base.");
            try
            {
                var connectionString = Console.ReadLine();

                using (var sqlConnection = new SqlConnection(connectionString)) {
                using(var command = sqlConnection.CreateCommand())
                {
                    /*command.CommandText(){

                    };*/
                }
            }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error, something went wrong. {0}", e.Message);
            }

            
        }


    }
}
