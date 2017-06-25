using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticketer.Data.Entities
{
    public class Bus
    {
        public int BusID { get; set; }

        //navigation property that maps bus to trip
        public virtual Trip Trip { get; set; }
    }
}
