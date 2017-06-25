using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticketer.Data.Entities
{
    public class Customer
    {
        //customer properties
        public int CustomerID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }




        //navigation property that maps customer to ticket
        public virtual Ticket Ticket { get; set; }
        //navigation property that maps customer to trip
        public virtual ICollection<Trip> Trips { get; set; } = new HashSet<Trip>();

    }
}
