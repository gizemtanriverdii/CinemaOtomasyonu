using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinematorium.Entities
{
    public class Session
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DayDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public virtual Saloon Saloons{ get; set; }
        public virtual Movie Movies{ get; set; }
        public virtual List<Ticket> Tickets { get; set; }
        public Session()
        {
            Tickets = new List<Ticket>();
        }
    }
}
