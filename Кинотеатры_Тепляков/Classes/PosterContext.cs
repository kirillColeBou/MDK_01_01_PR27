using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Кинотеатры_Тепляков.Models;

namespace Кинотеатры_Тепляков.Classes
{
    public class PosterContext : Poster
    {
        public PosterContext(int id, int idCinema, string nameFilm, string time, string price) : base(id, idCinema, nameFilm, time, price) { }
        public static List<PosterContext> AllPosters()
        {
            List<PosterContext> allPosters = new List<PosterContext>();
            MySqlConnection connection = Connection.DBConnection.OpenConnection();
            MySqlDataReader posterQuery = Connection.DBConnection.Query("SELECT * FROM Cinemas.poster", connection);
            while (posterQuery.Read())
            {
                allPosters.Add(new PosterContext(
                    posterQuery.GetInt32(1),
                    posterQuery.GetInt32(2),
                    posterQuery.GetString(3),
                    posterQuery.GetString(4),
                    posterQuery.GetString(5)));
            }
            connection.Close();
            MySqlConnection.ClearPool(connection);
            return allPosters;
        }
    }
}
