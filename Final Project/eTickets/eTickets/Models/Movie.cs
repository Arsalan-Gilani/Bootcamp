using eTickets.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Movie
    {

        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships

        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema
        public Cinema Cinema { get; set; }
    }
}
