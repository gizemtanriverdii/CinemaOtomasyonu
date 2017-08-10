using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinematorium.Entities
{
    public class Seat
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int SeatNo { get; set; }
        public string SeatChar { get; set; }
        public bool SeatHandicap { get; set; }
        public bool SeatBroken { get; set; }
        public bool Wiped_Seat { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public virtual Saloon Saloon { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
        public Seat()
        {
            Tickets = new List<Ticket>();
        }

    }
}
