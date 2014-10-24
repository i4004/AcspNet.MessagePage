using AcspNet.MessagePage.Controllers;
using AcspNet.Modules.Html;

namespace AcspNet.MessagePage.Responses
{
	/// <summary>
	/// Redirects the user to message page
	/// </summary>
	public class RedirectToMessagePage : ControllerResponse
	{
		private readonly string _message;
		private readonly MessageBoxStatus _status;

		/// <summary>
		/// Initializes a new instance of the <see cref="RedirectToMessagePage"/> class.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="status">The status.</param>
		public RedirectToMessagePage(string message, MessageBoxStatus status = MessageBoxStatus.Error)
		{
			_message = message;
			_status = status;
		}

		/// <summary>
		/// Processes this response
		/// </summary>
		/// <returns></returns>
		public override ControllerResponseResult Process()
		{
			Context.Response.Cookies.Append(MessagePageController.MessageFieldName, _message);
			Context.Response.Cookies.Append(MessagePageController.MessageStatusFieldName, _status.ToString());

			Redirector.Redirect(MessagePageController.Route);

			return ControllerResponseResult.Redirect;
		}
	}
}