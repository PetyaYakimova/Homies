using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Homies.Data.DataConstants;

namespace Homies.Data
{
	[Comment("Events")]
	public class Event
	{
		[Key]
		[Comment("Event identifier")]
		public int Id { get; set; }

		[Required]
		[MaxLength(EventNameMaxLength)]
		[Comment("Event Name")]
		public string Name { get; set; } = string.Empty;

		[Required]
		[MaxLength(EventDescriptionMaxLength)]
		[Comment("Event Description")]
		public string Description { get; set; } = string.Empty;

		[Required]
		[Comment("Event Organiser")]
		public string OrganiserId { get; set; } = string.Empty;

		[ForeignKey(nameof(OrganiserId))]
		public IdentityUser Organiser { get; set; } = null!;

		[Required]
		[Comment("Event Created On Date")]
		public DateTime CreatedOn { get; set; }

		[Required]
		[Comment("Event Start Date")]
		public DateTime Start { get; set; }

		[Required]
		[Comment("Event End Date")]
		public DateTime End { get; set; }

		[Required]
		[Comment("Event Type")]
		public int TypeId { get; set; }

		[ForeignKey(nameof(TypeId))]
		public Type Type { get; set; } = null!;

		public IList<EventParticipant> EventsParticipants { get; set; } = new List<EventParticipant>();
	}
}
