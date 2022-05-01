using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio3.Models
{
    public class SongModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Singer { get; set; }
        public string Language { get; set; }
        public DateTime ReleasedDate { get; set; }
    }
}
