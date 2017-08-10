using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinematorium.Entities
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public DateTime SellBy { get; set; }
        public DateTime MovieDay { get; set; }
        public decimal Price { get; set; }

        public virtual Customer customer { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Saloon Saloon { get; set; }
        public virtual Seat Seat { get; set; }
        public virtual User User { get; set; }
        public virtual Session Session { get; set; }

    }
}
