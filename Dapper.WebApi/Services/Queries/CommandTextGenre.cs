using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.movie.api.Services.Queries
{
    public class CommandTextGenre : ICommandTextGenre
    {
        public string GetGenres => "Select * from genre";
        public string GetGenreById => "Select * from genre where Id= @Id";
        public string AddGenre => "Insert into [dbo].[genre] (Name, Description) values (@Name, @Description)";
        public string UpdateGenre => "Update [dbo].[genre] set Name = @Name, Description = @Description where Id = @Id";
        public string RemoveGenre => "Delete from [dbo].[genre] where Id = @Id";
        public string GetGenreByIdSp => "GetGenreId";
    }
}
