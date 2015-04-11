using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;
using OpenQA.Selenium;

namespace Demo.AcceptanceTesting.Pages
{
	public class LoginPage : GenericPage
	{
		public LoginPage(Session session) : base(session)
		{
		}

		public ITextField<LoginPage> UsernameField
		{
			get {  return new TextField<LoginPage>(this, By.Id("username"));}
		}

		public ITextField<LoginPage> PasswordField
		{
			get {  return new TextField<LoginPage>(this, By.Id("password"));}
		}

		public IClickable LoginButton
		{
			get {  return new Clickable(this, By.Id("login"));}
		}
	}
}
