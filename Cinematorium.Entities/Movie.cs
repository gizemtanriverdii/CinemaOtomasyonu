using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinematorium.Entities
{
    public class Movie
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime DueDate { get; set; }
        public int Duration { get; set; }
        public bool HasDubbing { get; set; }
        public bool Is3D { get; set; }
        public string Description { get; set; }
        public string TrailerUrl { get; set; }

        public virtual List<MovieKind> MovieKinds { get; set; }
        public virtual List<Session> Sessions { get; set; }
        public virtual List<Saloon> Saloons { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
        
        public Movie()
        {
            MovieKinds = new List<MovieKind>();
            Sessions = new List<Session>();
            Saloons = new List<Saloon>();
            Tickets = new List<Ticket>();

        }
        //public override string ToString()
        //{
        //    return Name;
        //}
    }
}
