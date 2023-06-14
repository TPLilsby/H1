using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Npgsql;

namespace APITest
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
    }
}
