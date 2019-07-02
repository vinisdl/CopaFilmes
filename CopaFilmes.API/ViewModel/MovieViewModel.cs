using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmes.API.ViewModel
{
    public class MovieViewModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("titulo")]
        public string Title { get; set; }
        [JsonProperty("ano")]
        public int ReleaseYear { get; set; }
        [JsonProperty("nota")]
        public decimal Score { get; set; }
    }
}
