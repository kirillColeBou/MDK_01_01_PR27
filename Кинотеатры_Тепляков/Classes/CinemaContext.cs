using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Кинотеатры_Тепляков.Models;

namespace Кинотеатры_Тепляков.Classes
{
    public class CinemaContext : Cinema
    {
        public CinemaContext(int id, string nameCinema, int countHall, int countPlace) : base(id, nameCinema, countHall, countPlace) { }
        public static List<CinemaContext> AllCinemas()
        {
            List<CinemaContext> allCinemas = new List<CinemaContext>();
            MySqlConnection connection = Connection.DBConnection.OpenConnection();
            MySqlDataReader cinemaQuery = Connection.DBConnection.Query("SELECT * FROM Cinemas.cinema", connection);
            while (cinemaQuery.Read())
            {
                allCinemas.Add(new CinemaContext(
                    cinemaQuery.GetInt32(1),
                    cinemaQuery.GetString(2),
                    cinemaQuery.GetInt32(3),
                    cinemaQuery.GetInt32(4)));
            }
            connection.Close();
            MySqlConnection.ClearPool(connection);
            return allCinemas;
        }
    }
}
