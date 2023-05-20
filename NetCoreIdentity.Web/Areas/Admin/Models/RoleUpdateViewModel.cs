using System.ComponentModel.DataAnnotations;

namespace NetCoreIdentity.Web.Areas.Admin.Models
{
    public class RoleUpdateViewModel
    {
        public string Id { get; set; } = null!;

        [Display(Name = "Rol İsmi :")]
        [Required(ErrorMessage = "Rol ismi boş bırakılamaz.")]
        public string Name { get; set; }
    }
}
