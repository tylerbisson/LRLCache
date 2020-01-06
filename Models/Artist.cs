using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RecordsApi.Models
{
    public class Artist
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
