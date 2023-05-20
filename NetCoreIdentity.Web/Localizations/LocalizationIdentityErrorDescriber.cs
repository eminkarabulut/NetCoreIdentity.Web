using Microsoft.AspNetCore.Identity;

namespace NetCoreIdentity.Web.Localizations
{
	public class LocalizationIdentityErrorDescriber:IdentityErrorDescriber
	{
		public override IdentityError DuplicateUserName(string userName)
		{
			return new() { Description = $"'{userName}' Kullanıcı adı zaten alındı." ,Code="DuplicateUserName"};
		}

		public override IdentityError DuplicateEmail(string email)
		{
			return new() { Code = "DuplicateEmail", Description = $"Bu email {email} zaten alındı." };
		}

		public override IdentityError PasswordTooShort(int length)
		{
			return new() { Code = "PasswordTooShort", Description = "Şifre en az 6 karakterli olmalıdır." };
		}

	}
}
