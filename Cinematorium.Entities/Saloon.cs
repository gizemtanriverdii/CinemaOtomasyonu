using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinematorium.Entities
{
    public class Saloon
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public int rownumber { get; set; }

        public int columnnumber { get; set; }

        public virtual List<Session> Sessions { get; set; }
        public virtual List<Seat> Seats { get; set; }
        public virtual List<Movie> Movies { get; set; }

    }
}
