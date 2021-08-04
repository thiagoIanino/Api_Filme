using System;

namespace projeto.movie.api.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
       
        public DateTime ReleaseDate { get; set; }
        public string Duration { get; set; }

        public int Id_Genre { get; set; }

        public string GenreName { get; set; }
    }
}