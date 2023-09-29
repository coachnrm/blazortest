using System;
namespace BlazorEcommerce.Shared
{
	public class User
	{
		public int Id { get; set; }

		public string Email { get; set; } = string.Empty;

		public byte[] PasswordHush { get; set; }

		public byte[] PasswordSalt { get; set; }

		public DateTime DateCreated { get; set; } = DateTime.Now;
	}
}

