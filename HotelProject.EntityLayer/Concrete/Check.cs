using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Check
    {
        public int CheckID { get; set; }
        public DateTime InDate { get; set; }
        public DateTime OutDate { get; set; }
        public int PersonCount { get; set; }
    }
}
