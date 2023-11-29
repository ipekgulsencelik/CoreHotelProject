using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Gallery
    {
        public int GalleryID { get; set; }
        public string ImageUrl { get; set; }
    }
}
