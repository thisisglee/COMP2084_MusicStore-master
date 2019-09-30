using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP2084_MusicStore.Models
{
    public class Genre
    {   
        [Key]
        public int GenreId { get; set; }

        public string Name { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}