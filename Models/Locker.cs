using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LockerWebApp.Models
{
    public class Locker
    {
        public int Id { get; set; }
        public int Floor { get; set; }
        public int LockerNumber { get; set; }
        public Locker()
        {

        }
    }
}
