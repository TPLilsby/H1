using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Npgsql;
using Portofolio_hjemmesideCSharp;
using System.Data.SqlTypes;
using System.Diagnostics;

namespace Portofolio_hjemmesideCSharp
{
    //DALManager class, get things from the database
    public class DALManager
    {
        //Private readonly IConfiguration instance used for accessing configuration settings
        private readonly IConfiguration Configuration;

        //Constructor for DALManager class
        public DALManager(IConfiguration configuration)
        {
            //Assign the provided IConfiguration instance to the Configuration property
            Configuration = configuration;
        }

        //Return the fetched list of Cv objects
        public List<Cv> GetCv()
        {
            //Create a new list to store the fetched Cv objects
            List<Cv> cvList = new List<Cv>();

            //Create a new NpgsqlConnection using the specified connectionString from the appsettings
            using (NpgsqlConnection connection = new NpgsqlConnection(Configuration["ConnectionString"]))
            {
                //Try statement
                try
                {
                    //Makes a new NpgSglCommand named command
                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {
                        //Set the command's connection and query for get_cv(1) sql function
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM get_cv(1)";

                        //Open the database connection
                        connection.Open();

                        //Execute the command and retrieve the results using a NpgsqlDataReader
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Create a new Cv object and add it to the cvList,  with the diffrent columns in the database
                                cvList.Add(new Cv(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
                            }
                        }
                    }
                }
                //Catch database exceptions
                catch (NpgsqlException npg)
                {
                    //Print it to the debug console
                    Debug.Write("22222222222222222222222222222222222" + npg.Message);
                }
                //Catch all other exceptions
                catch (Exception ex)
                {
                    //Print it to the debug console
                    Debug.Write("An error occurred: " + ex.Message);
                }
                finally
                {
                    //Close the database connection in the finally block
                    connection.Close();
                }
            }

            //Return the fetched list of Cv objects
            return cvList;
        }

         //Return the fetched list of Project objects
        public List<Project> GetProject()
        {
            //Create a new list to store the fetched Project objects
            List<Project> projectList = new List<Project>();

            //Create a new NpgsqlConnection using the specified connectionString from the appsettings
            using (NpgsqlConnection connection = new NpgsqlConnection(Configuration["ConnectionString"]))
            {
                //Try statement
                try
                {
                    //Makes a new NpgSglCommand named command
                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {
                        //Set the command's connection and query for getproject() sql function
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM getproject()";

                        //Open the database connection
                        connection.Open();

                        //Execute the command and retrieve the results using a NpgsqlDataReader
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Create a new Project object and add it to the projectList,  with the diffrent columns in the database
                                projectList.Add(new Project(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
                            }
                        }
                     }
                }
                //Catch database exceptions
                catch (NpgsqlException npg)
                {
                    //Print it to the debug console
                    Debug.Write("22222222222222222222222222222222222" + npg.Message);
                }
                //Catch all other exceptions
                catch (Exception ex)
                {
                    //Print it to the debug console
                    Debug.Write("An error occurred: " + ex.Message);
                }
                finally
                {
                    //Close the database connection in the finally block
                    connection.Close();
                }
            }

            //Return the fetched list of Project objects
            return projectList;
        }

        //Method named GetTechnology that return a list Technology objects
        public List<Technology> GetTechnology()
        {
            //Create a new list to store the fetched Technology objects
            List<Technology> tecknologyList = new List<Technology>();

            //Create a new NpgsqlConnection using the specified connectionString from the appsettings
            using (NpgsqlConnection connection = new NpgsqlConnection(Configuration["ConnectionString"]))
            {
                //Try statement
                try
                {
                    //Makes a new NpgSglCommand named command
                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {
                        //Set the command's connection and query for gettechnology() sql function
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM gettechnology()";

                        //Open the database connection
                        connection.Open();

                        //Execute the command and retrieve the results using a NpgsqlDataReader
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Create a new Technology object and add it to the technologyList,  with the diffrent columns in the database
                                tecknologyList.Add(new Technology(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                            }
                        }
                    }
                }
                //Catch database exceptions
                catch (NpgsqlException npg)
                {
                    //Print it to the debug console
                    Debug.Write("22222222222222222222222222222222222" + npg.Message);
                }
                //Catch all other exceptions
                catch (Exception ex)
                {
                    //Print it to the debug console
                    Debug.Write("An error occurred: " + ex.Message);
                }
                finally
                {
                    //Close the database connection in the finally block
                    connection.Close();
                }
            }

            //Return the fetched list of Technology objects
            return tecknologyList;
        }
    }
}