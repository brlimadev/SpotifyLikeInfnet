using SpotifyLike.Domain.Streaming.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLike.Domain.Streaming.Aggregates
{
    public class Banda
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Descricao { get; set; }
        public String BackDrop { get; set; }
        public Duracao Duracao { get; set; }
        public List<Album> Albums { get; set; } = new List<Album>();

    }
}
