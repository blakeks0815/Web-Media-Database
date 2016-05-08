using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Media_Database.Models
{
    public class MediaObject
    {
        [Key]
        public long ID { get; set; }
        public string Titel { get; set; }
        public string Owner { get; set; }
        public string Path { get; set; }

    }
}
