using System.ComponentModel.DataAnnotations;
using static Homies.Data.DataConstants;

namespace Homies.Models
{
	public class EventFormViewModel
	{
		[Required(ErrorMessage = RequiredFieldErrorMessage)]
		[StringLength(EventNameMaxLength, MinimumLength = EventNameMinLength, ErrorMessage = StringLengthErrorMessage)]
		public string Name { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredFieldErrorMessage)]
		[StringLength(EventDescriptionMaxLength, MinimumLength = EventDescriptionMinLength, ErrorMessage = StringLengthErrorMessage)]
		public string Description { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredFieldErrorMessage)]
		public string Start { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredFieldErrorMessage)]
		public string End { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredFieldErrorMessage)]
		public int TypeId { get; set; }

		public IEnumerable<TypeViewModel> Types { get; set; } = new List<TypeViewModel>();
	}
}
