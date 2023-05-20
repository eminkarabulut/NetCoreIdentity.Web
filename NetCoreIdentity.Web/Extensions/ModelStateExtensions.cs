using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace NetCoreIdentity.Web.Extensions
{
	public static class ModelStateExtensions
	{
		public static void AddModelErrorList(this ModelStateDictionary modelstate,List<string> errors)
		{
			foreach (var error in errors)
			{
				modelstate.AddModelError(string.Empty, error);

			}
		}

        public static void AddModelErrorList(this ModelStateDictionary modelstate, IEnumerable<IdentityError> errors)
        {
            foreach (var error in errors.ToList())
            {
                modelstate.AddModelError(string.Empty, error.Description);

            }
        }
    }
}
