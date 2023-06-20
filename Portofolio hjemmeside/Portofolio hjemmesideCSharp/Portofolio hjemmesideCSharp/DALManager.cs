using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Npgsql;
using Portofolio_hjemmesideCSharp;
using System.Data.SqlTypes;
using System.Diagnostics;

namespace Portofolio_hjemmesideCSharp
{
    public class DalManager
    {
        private readonly IConfiguration Configuration;

        public DalManager(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public List<WeatherForecast> GetWeatherForecast()
        {
            List<WeatherForecast> weatherForecasts = new List<WeatherForecast>();

            using (NpgsqlConnection connection = new NpgsqlConnection(Configuration["ConnectionString"]))
            {
                try
                {
                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM getwfc(1)";

                        connection.Open();

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                weatherForecasts.Add(new WeatherForecast(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4)));
                            }
                        }
                    }
                }

                catch (NpgsqlException npg)
                {
                    Debug.Write("22222222222222222222222222222222222" + npg.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return weatherForecasts;

        }

        public List<Cv> GetCv()
        {
            List<Cv> cv = new List<Cv>();

            using (NpgsqlConnection connection = new NpgsqlConnection(Configuration["ConnectionString"]))
            {
                try
                {
                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM get_cv(1)";

                        connection.Open();

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cv.Add(new Cv(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
                            }
                        }
                    }
                }
                catch (NpgsqlException npg)
                {
                    Debug.Write("22222222222222222222222222222222222" + npg.Message);
                }
                catch (Exception ex)
                {
                    Debug.Write("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return cv;
        }

        public List<Project> GetProject()
        {
            List<Project> projectList = new List<Project>();

            using (NpgsqlConnection connection = new NpgsqlConnection(Configuration["ConnectionString"]))
            {
                try
                {
                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM getproject()";

                        connection.Open();

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                projectList.Add(new Project(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
                            }
                        }
                     }
                }
                catch (NpgsqlException npg)
                {
                    Debug.Write("22222222222222222222222222222222222" + npg.Message);
                }
                catch (Exception ex)
                {
                    Debug.Write("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return projectList;
        }

        public List<Technology> GetTechnology()
        {
            List<Technology> projectList = new List<Technology>();

            using (NpgsqlConnection connection = new NpgsqlConnection(Configuration["ConnectionString"]))
            {
                try
                {
                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM gettechnology()";

                        connection.Open();

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                projectList.Add(new Technology(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                            }
                        }
                    }
                }
                catch (NpgsqlException npg)
                {
                    Debug.Write("22222222222222222222222222222222222" + npg.Message);
                }
                catch (Exception ex)
                {
                    Debug.Write("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return projectList;
        }
    }
}