﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Message
    {
        public int MessageID { get; set; }
        public string Mail { get; set; }
        public string NameSurname { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
    }
}
