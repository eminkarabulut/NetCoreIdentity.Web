using NetCoreIdentity.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace NetCoreIdentity.Web.ViewModels
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Kullanıcı Ad alanı boş bırakılamaz.")]
        [Display(Name = "Kullanıcı Adı :")]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage = "Email formatı yanlıştır.")]
        [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
        [Display(Name = "Email :")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon alanı boş bırakılamaz.")]
        [Display(Name = "Telefon :")]
        public string Phone { get; set; } = null!;

        [Display(Name ="Doğum Tarihi")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        [Display(Name ="Şehir Bilgisi")]
        public string? City { get; set; }

        [Display(Name ="Profil Resmi")]
        public IFormFile? Picture { get; set; }

        [Display(Name ="Cinsiyet")]
        public Gender? Gender { get; set; }
    }
}
