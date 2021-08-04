using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.movie.api.Services.Queries
{
  public  interface ICommandTextGenre
    {
        string GetGenres { get; }
        string GetGenreById { get; }
        string AddGenre { get; }
        string UpdateGenre { get; }
        string RemoveGenre { get; }
        string GetGenreByIdSp { get; }
    }
}
