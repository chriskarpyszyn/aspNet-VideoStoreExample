using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoStoreExample.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumberInStock { get; set; }
        public Genres Genres { get; set; }
        public byte GenresId { get; set; }
    }

}