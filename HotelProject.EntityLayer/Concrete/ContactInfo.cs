namespace HotelProject.EntityLayer.Concrete
{
	public class ContactInfo
    {
        public int ContactInfoID { get; set; }     
        public string? Address { get; set; }     
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Fax { get; set; }
        public bool IsActive { get; set; }
    }
}