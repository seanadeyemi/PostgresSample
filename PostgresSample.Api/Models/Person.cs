using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PostgresSample.Api.DTOs;

namespace PostgresSample.Api.Models
{
	[Table("Person")]
	public class Person
	{
		public int Id { get; set; }

		[Column(TypeName = "varchar(30)")]
		[Required]
		public required string Name { get; set; }

		public static GetPersonDto ToGetPersonDto(Person person)
		{
			return new GetPersonDto
			{
				Id = person.Id,
				Name = person.Name
			};
		}
	}
}
