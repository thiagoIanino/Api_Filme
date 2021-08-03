namespace projeto.movie.api.Services.Queries
{
    public class CommandText : ICommandText
    {
        public string GetMovies => "Select * from movie";
        public string GetMovieById => "Select * from movie where Id= @Id";
        public string AddMovie => "Insert into [dbo].[movie] (Title, Director, Genres, ReleaseDate, Duration) values (@Title, @Director, @Genres, @ReleaseDate, @Duration)";
        public string UpdateMovie => "Update [dbo].[movie] set Title = @Title, Director = @Director, Genres = @Genres, ReleaseDate = GETDATE(), Duration = @Duration where Id = @Id";
        public string RemoveMovie => "Delete from [dbo].[movie] where Id = @Id";
        public string GetMovieByIdSp => "GetMovieId";

    }
}
