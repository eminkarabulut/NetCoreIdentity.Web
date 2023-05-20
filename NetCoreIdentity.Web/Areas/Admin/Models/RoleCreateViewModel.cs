using System.ComponentModel.DataAnnotations;

namespace NetCoreIdentity.Web.Areas.Admin.Models
{
    public class RoleCreateViewModel
    {
        [Display(Name = "Rol İsmi :")]
        [Required(ErrorMessage ="Rol ismi boş bırakılamaz.")]
        public string? Name { get; set; }
    }
}
