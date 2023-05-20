using System.ComponentModel.DataAnnotations;

namespace NetCoreIdentity.Web.ViewModels
{
	public class ResetPasswordViewModel
	{

		[Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
		[Display(Name = "Yeni Şifre :")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Compare(nameof(Password), ErrorMessage = "Şifre aynı değildir.")]
		[Required(ErrorMessage = "Şifre tekrar alanı boş bırakılamaz.")]
		[Display(Name = "Yeni Şifre Tekrar :")]
		[DataType(DataType.Password)]
		public string PasswordConfirm { get; set; }
	}
}
