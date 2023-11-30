namespace HotelProject.EntityLayer.Concrete
{
	public class SocialMedia
	{
		public int SocialMediaID { get; set; }
		public string? Title { get; set; }
		public string? SocialMediURL { get; set; }
		public string? Icon { get; set; }
		public bool IsActive { get; set; }
	}
}