namespace HotelProject.DTOLayer.DTOs.AboutDTOs
{
	public class UpdateAboutDTO
	{
		public int AboutID;
		public string? Title1 { get; set; }
		public string? Title2 { get; set; }
		public string? Description1 { get; set; }
		public string? Description2 { get; set; }
		public string? VideoURL { get; set; }
		public bool IsActive { get; set; }
	}
}