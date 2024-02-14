using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homies.Data
{
	[Comment("Events Participants")]
	public class EventParticipant
	{
		[Required]
		[Comment("Helper Identifier")]
		public string HelperId { get; set; } = string.Empty;

		[ForeignKey(nameof(HelperId))]
		public IdentityUser Helper { get; set; } = null!;

		[Required]
		[Comment("Event Identifier")]
		public int EventId { get; set; }

		[ForeignKey(nameof(EventId))]
		public Event Event { get; set; } = null!;
	}
}