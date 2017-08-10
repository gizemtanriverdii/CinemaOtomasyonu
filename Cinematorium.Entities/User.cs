using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinematorium.Entities
{
 public   class User
    {

        public string UserName { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string EmployeeKind { get; set; }
        public DateTime? StartWorkDate { get; set; }
        public decimal? Salary { get; set; }
        public bool? IsWorking { get; set; }
        public virtual List<Ticket> Ticket{ get; set; }

    }

}
