using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Media_Database.Models
{
    public class GamesViewModel {

        public IEnumerable<Game> Games { get; set; }
        public Game NewGame { get; set; }
    }
}
