using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Media_Database.Models
{
    public class Games : MediaObject
    {
        public string Genre { get; set; }
        public int Size { get; set; }
    }
}
