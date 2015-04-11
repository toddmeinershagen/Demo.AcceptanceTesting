using Bumblebee.Implementation;
using Bumblebee.Setup;

namespace Demo.AcceptanceTesting.Pages
{
	public class GenericPage : WebBlock
	{
		public GenericPage(Session session) : base(session)
		{
		}

		public string Title
		{
			get
			{
				return Session.Driver.Title;
			}
		}
	}
}
