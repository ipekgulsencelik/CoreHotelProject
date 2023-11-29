using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class OurRoom
    {
        public int OurRoomID { get; set; }         
        public string ImageUrl { get; set; }         
        public decimal Price { get; set; }         
        public int PersonCount { get; set; }         
        public string RoomType { get; set; }         
        public string RoomSize { get; set; }       
        public int BedCount {  get; set; }
        public string RoomView {  get; set; }
        
    }
}
