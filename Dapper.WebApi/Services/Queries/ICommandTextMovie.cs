namespace projeto.movie.api.Services.Queries
{
    public interface ICommandTextMovie
    {
        string GetMovies { get; }
        string GetMovieById { get; }
        string AddMovie { get; }
        string UpdateMovie { get; }
        string RemoveMovie { get; }
        string GetMovieByIdSp { get; }
    }
}
