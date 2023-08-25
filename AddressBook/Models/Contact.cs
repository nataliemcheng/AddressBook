using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressBook.Models
{
	public class Contact
	{
		[Required]
		[Display(Name = "First Name")]
		public required string FirstName { get; set; }

		[Required]
        [Display(Name = "Last Name")]
        public required string LastName { get; set; }

		[Required]
		public required string Address1 { get; set; }
        public string? Address2 { get; set; }
		public required string City { get; set; }
		public required string State { get; set; }

		[DataType(DataType.PostalCode)]
		public int Zip { get; set; }

		[DataType(DataType.EmailAddress)]
		public required string Email { get; set; }

		[DataType(DataType.PhoneNumber)]
		public required string Phone { get; set; }

		public DateTime Created { get; set; }

        [NotMapped]
        [Display(Name = "Image")]
		[DataType(DataType.Upload)]
        public IFormFile? ImageFile { get; set; }
		public byte[]? ImageData { get; set; }
		public string? ImageType { get; set; }

		public int Id { get; set; }

		[NotMapped]
		public string FullName { get { return $"{FirstName} {LastName}"; } }
	}
}

