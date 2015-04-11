using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;
using OpenQA.Selenium;

namespace Demo.AcceptanceTesting.Pages
{
	public class KeyPressPage : GenericPage
	{
		public KeyPressPage(Session session) : base(session)
		{
		}

		public ITextField<KeyPressPage> EntryField
		{
			get {  return new TextField<KeyPressPage>(this, By.Id("entryField"));}
		}

		public string Message
		{
			get { return GetElement(By.Id("message")).Text; }
		}
	}
}
