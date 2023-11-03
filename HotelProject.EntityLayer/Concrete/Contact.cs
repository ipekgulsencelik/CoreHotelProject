﻿using System.ComponentModel.DataAnnotations;

namespace HotelProject.EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserMail { get; set; }

        [StringLength(50)]
        public string Subject { get; set; }

        public DateTime ContactDate { get; set; }

        // [AllowHtml]
        public string Message { get; set; }

        public bool IsRead { get; set; }
        public bool IsImportant { get; set; }
    }
}