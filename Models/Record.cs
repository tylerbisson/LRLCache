using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RecordsApi.Models
{
    public class Record
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Rank { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
    }
}
