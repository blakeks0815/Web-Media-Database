using System.ComponentModel.DataAnnotations;

namespace Media_Database.Models
{
    public class MediaObject {
        [Key]
        public long ID { get; set; }
        public string Titel { get; set; }
        public string Owner { get; set; }
        public string Path { get; set; }

    }
}
