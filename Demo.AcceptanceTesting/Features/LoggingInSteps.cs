using Bumblebee.Extensions;
using Bumblebee.Setup;
using Bumblebee.Setup.DriverEnvironments;
using Demo.AcceptanceTesting.Pages;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace Demo.AcceptanceTesting.Features
{
	[Binding]
	public class LoggingInSteps
	{
		[Given(@"valid username")]
		public void GivenValidUsername()
		{
			ScenarioContext.Current.Set("todd@meinershagen.net", "username");
		}

		[Given(@"valid password")]
		public void GivenValidPassword()
		{
			ScenarioContext.Current.Set("password", "password");
		}

		[Given(@"invalid username of '(.*)'")]
		public void GivenInvalidUsername(string username)
		{
			ScenarioContext.Current.Set(username, "username");
		}

		[Given(@"invalid password of '(.*)'")]
		public void GivenInvalidPassword(string password)
		{
			ScenarioContext.Current.Set(password, "password");
		}

		[When(@"I login")]
		public void WhenILogin()
		{
			var username = ScenarioContext.Current.Get<string>("username");
			var password = ScenarioContext.Current.Get<string>("password");

			Threaded<Session>
				.With<InternetExplorer>()
				.NavigateTo<LoginPage>(string.Format("{0}/{1}", NancyHostSetup.BaseUrl, "Content/LoginPage.html"))
				.UsernameField.EnterText(username)
				.PasswordField.EnterText(password)
				.LoginButton.Click<GenericPage>();
		}

		[Then(@"the app should take me to the home page")]
		public void ThenTheAppShouldTakeMeToTheHomePage()
		{
			Threaded<Session>
				.CurrentBlock<HomePage>()
				.VerifyThat(p => p.Title.Should().Be("Home Page"));
		}

		[Then(@"the app should take me to the login page")]
		public void ThenTheAppShouldTakeMeToTheLoginPage()
		{
			Threaded<Session>
				.CurrentBlock<HomePage>()
				.VerifyThat(p => p.Title.Should().Be("Login Page"));
		}

		[AfterScenario]
		public static void AfterScenario()
		{
			Threaded<Session>
				.End();
		}

	}
}
