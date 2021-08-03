using System;

namespace projeto.movie.api.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genres { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Duration { get; set; }

    }
}