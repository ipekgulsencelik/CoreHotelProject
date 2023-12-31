﻿using System.ComponentModel.DataAnnotations;

namespace HotelProject.EntityLayer.Concrete
{
	public class Message
    {
		public int MessageID { get; set; }

		[StringLength(50)]
		public string? SenderMail { get; set; }

		[StringLength(50)]
		public string? ReceiverMail { get; set; }

		[StringLength(100)]
		public string? Subject { get; set; }

		public string? MessageContent { get; set; }
		public DateTime MessageDate { get; set; }

		public bool IsDraft { get; set; }
		public bool IsTrash { get; set; }
		public bool IsRead { get; set; }
		public bool IsImportant { get; set; }
		public bool IsSpam { get; set; }
	}
}