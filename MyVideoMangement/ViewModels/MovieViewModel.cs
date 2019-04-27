using System.Collections.Generic;
using MyVideoMangement.Models;

namespace MyVideoMangement.ViewModels
{
    public class MovieViewModel
    {
        public Movie Movie { get; set; }
        public IList<Movie> Movies { get; set; }
    }
}