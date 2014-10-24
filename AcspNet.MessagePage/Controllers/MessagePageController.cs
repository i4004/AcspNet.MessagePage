using System;
using AcspNet.Attributes;
using AcspNet.Modules.Html;
using AcspNet.Responses;
using Microsoft.Owin;
using MessageBox = AcspNet.Responses.MessageBox;

namespace AcspNet.MessagePage.Controllers
{
	/// <summary>
	/// Message page controller
	/// </summary>
	[Get(Route)]
	public class MessagePageController : Controller
	{
		/// <summary>
		/// The message page route
		/// </summary>
		public const string Route = "message";

		/// <summary>
		/// The message field name
		/// </summary>
		public const string MessageFieldName = "Message";
		/// <summary>
		/// The message status field name
		/// </summary>
		public const string MessageStatusFieldName = "MessageStatus";

		/// <summary>
		/// Invokes the controller.
		/// </summary>
		public override ControllerResponse Invoke()
		{
			var message = Context.Request.Cookies[MessageFieldName];
			var messageStatus = Context.Request.Cookies[MessageStatusFieldName];

			if (string.IsNullOrEmpty(message) || string.IsNullOrEmpty(messageStatus))
				return new Redirect();

			Context.Response.Cookies.Delete(MessageFieldName, new CookieOptions { Expires = DateTime.Now.AddDays(-1D) });
			Context.Response.Cookies.Delete(MessageStatusFieldName, new CookieOptions { Expires = DateTime.Now.AddDays(-1D) });

			MessageBoxStatus status;

			if (!Enum.TryParse(messageStatus, out status))
				return new Redirect();

			return new MessageBox(message, status);
		}
	}
}