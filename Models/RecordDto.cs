using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecordsApi.Models
{
    public class RecordDto
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public string ArtistName { get; set; }
    }
}
