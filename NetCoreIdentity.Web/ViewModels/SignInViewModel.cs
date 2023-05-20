using System.ComponentModel.DataAnnotations;

namespace NetCoreIdentity.Web.ViewModels
{
	public class SignInViewModel
	{
		[Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
		[Display(Name = "Email :")]
		[EmailAddress(ErrorMessage = "Email formatı yanlıştır.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
		[Display(Name = "Şifre :")]
		[DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olmalıdır.")]
        public string Password { get; set; }

		[Display(Name = "Beni Hatırla")]
		public bool RememberMe { get; set; }

    }
}
