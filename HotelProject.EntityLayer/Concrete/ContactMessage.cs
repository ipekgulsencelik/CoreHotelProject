namespace HotelProject.EntityLayer.Concrete
{
	public class ContactMessage
    {
		public int ContactMessageID { get; set; }
		public string? Mail { get; set; }
		public string? NameSurname { get; set; }
		public string? Subject { get; set; }
		public string? MessageContent { get; set; }
		public bool IsActive { get; set; }
    }
}