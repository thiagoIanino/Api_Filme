namespace projeto.movie.api.Services.Queries
{
    public class CommandTextMovie : ICommandTextMovie
    {
        public string GetMovies => "Select m.Id,m.Title,m.Director, m.ReleaseDate,m.Duration,m.Id_Genre,g.Name as [GenreName] from movie as m join genre as g on m.Id_Genre = g.Id";
        public string GetMovieById => "Select m.Id,m.Title,m.Director, m.ReleaseDate,m.Duration,m.Id_Genre,g.Name as [GenreName] from movie as m join genre as g on m.Id_Genre = g.Id where m.Id= @Id";
        public string AddMovie => "Insert into [dbo].[movie] (Title, Director, ReleaseDate, Duration, Id_Genre) values (@Title, @Director, @ReleaseDate, @Duration,@Id_Genre)";
        public string UpdateMovie => "Update [dbo].[movie] set Title = @Title, Director = @Director,  ReleaseDate = GETDATE(), Duration = @Duration, Id_Genre = @Id_Genre where Id = @Id";
        public string RemoveMovie => "Delete from [dbo].[movie] where Id = @Id";
        public string GetMovieByIdSp => "GetMovieId";

    }
}
