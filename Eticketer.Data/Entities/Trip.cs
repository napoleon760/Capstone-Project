using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticketer.Data.Entities
{

    public class Trip
    {
        
        public int TripID { get; set; }

        //navigation property to map trip to ticket
        public virtual ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
        //navigation property to map trip to customer
        public virtual ICollection<Customer> Customers { get; set; } = new HashSet<Customer>();
        //navigation property to map trip to route
        public virtual Route Route { get; set; }
        public virtual ICollection<Bus> Buses { get; set; } = new HashSet<Bus>();
    }
}
