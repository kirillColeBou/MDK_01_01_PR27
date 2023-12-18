using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кинотеатры_Тепляков.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        public string NameCinema { get; set; }
        public int CountHall { get; set; }
        public int CountPlace { get; set; }
        public Cinema() { }
        public Cinema(int id, string nameCinema, int countHall, int countPlace)
        {
            this.Id = id;
            this.NameCinema = nameCinema;
            this.CountHall = countHall;
            this.CountPlace = countPlace;
        }
    }
}
