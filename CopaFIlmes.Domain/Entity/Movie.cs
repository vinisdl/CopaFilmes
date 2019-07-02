using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFIlmes.Domain.Entity
{
    public class Movie
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public decimal Score { get; set; }
        public override string ToString()
        {
            return $"Title: {Title} Score: {Score}" ;
        }
    }
}
