using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string NameSurname { get; set; }
        public DateTime CommentDate { get; set; }
        public string Message { get; set; }
        public string ImageUrl { get; set; }

    }
}
