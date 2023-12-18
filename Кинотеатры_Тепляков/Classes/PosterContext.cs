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
        public PosterContext(int id, int idCinema, string nameFilm, string time, string price, string nameCinema) : base(id, idCinema, nameFilm, time, price, nameCinema) { }
        public static List<PosterContext> AllPosters()
        {
            List<CinemaContext> cinemaContexts = CinemaContext.AllCinemas();
            List<PosterContext> allPosters = new List<PosterContext>();
            MySqlConnection connection = Connection.DBConnection.OpenConnection();
            MySqlDataReader posterQuery = Connection.DBConnection.Query("SELECT * FROM Cinemas.poster", connection);
            while (posterQuery.Read())
            {
                CinemaContext cinemaContext = cinemaContexts.Find(x => x.Id == posterQuery.GetInt32(1));
                allPosters.Add(new PosterContext(
                    posterQuery.GetInt32(0),
                    posterQuery.GetInt32(1),
                    posterQuery.GetString(2),
                    posterQuery.GetString(3),
                    posterQuery.GetString(4),
                    cinemaContext.NameCinema));
            }
            connection.Close();
            MySqlConnection.ClearPool(connection);
            return allPosters;
        }
    }
}
