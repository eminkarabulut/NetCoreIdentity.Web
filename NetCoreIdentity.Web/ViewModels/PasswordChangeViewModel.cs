using System.ComponentModel.DataAnnotations;

namespace NetCoreIdentity.Web.ViewModels
{
    public class PasswordChangeViewModel
    {
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        [Display(Name = "Eski Şifre :")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olmalıdır.")]
        public string PasswordOld { get; set; } = null!;

        [Required(ErrorMessage = "Yeni şifre alanı boş bırakılamaz.")]
        [Display(Name =  "Yeni Şifre :")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olmalıdır.")]
        public string PasswordNew { get; set; } = null!;

        [Required(ErrorMessage = "Yeni şifre tekrar alanı boş bırakılamaz.")]
        [Display(Name = "Yeni Şifre Tekrar :")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olmalıdır.")]
        public string PasswordNewConfirm { get; set; } = null!;
    }
}
