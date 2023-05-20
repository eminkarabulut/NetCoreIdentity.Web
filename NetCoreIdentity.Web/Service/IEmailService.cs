namespace NetCoreIdentity.Web.Service
{
	public interface IEmailService
	{
		Task SendResetPasswordEmail(string resetPasswordEmailLink, string toEmail);

	}
}
