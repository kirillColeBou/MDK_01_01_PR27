using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кинотеатры_Тепляков.Models
{
    public class Poster
    {
        public int Id { get; set; }
        public int IdCinema { get; set; }
        public string NameFilm { get; set; }
        public string Time { get; set; }
        public string Price { get; set; }
        public Poster() { }
        public Poster(int id, int idCinema, string nameFilm, string time, string price)
        {
            this.Id = id;
            this.IdCinema = idCinema;
            this.NameFilm = nameFilm;
            this.Time = time;
            this.Price = price;
        }
    }
}
