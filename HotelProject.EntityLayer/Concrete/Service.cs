﻿namespace HotelProject.EntityLayer.Concrete
{
	public class Service
    {
        public int ServiceID { get; set; }
        public string? Icon { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsHome { get; set; }
        public bool IsActive { get; set; }
    }
}