using PostgresSample.Api.Models;
using System.ComponentModel.DataAnnotations;

namespace PostgresSample.Api.DTOs
{
	public class CreatePersonDTO
	{
		[Required]
		public required string Name { get; set; }

		public static Person ToPerson(CreatePersonDTO createPersonDto)
		{
			return new Person
			{
				Name = createPersonDto.Name
			};
		}
	}
}
