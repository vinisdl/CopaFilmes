using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CopaFIlmes.Domain.Entity
{
    public class WorldCup
    {

        public WorldCup(IList<Movie> movies)
        {
            Movies = movies.OrderBy(a => a.Title);            
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public bool IsValid() => Movies.Count() != 0 && Movies.Count() % 2 == 0;

        public IEnumerable<Movie> Movies { get; set; }

        public List<Movie> RunCup() => GetTopTwo(Movies).ToList();

        private IEnumerable<Movie> GetTopTwo(IEnumerable<Movie> movies)
        {
            if (movies.Count() == 2)
                return GetWinner(movies.ElementAt(0), movies.ElementAt(1));

             return GetTopTwo(GetNextBracket(movies));
        }

        private IEnumerable<Movie> GetNextBracket(IEnumerable<Movie> enumerable)
        {
            var resultOfMatches = new List<Movie>();
            for (int i = 0; i < enumerable.Count() / 2; i++)
            {
                resultOfMatches.Add(GetWinner(enumerable.ElementAt(i), enumerable.ElementAt(enumerable.Count() - 1 - i)).FirstOrDefault());
            }
            return resultOfMatches;
        }

        public static IEnumerable<Movie> GetWinner(Movie top, Movie lower)
        {
            return new List<Movie>() { top, lower }
            .OrderByDescending(a => a.Score)
            .ThenBy(a => a.Title);            
        }

    }
}
