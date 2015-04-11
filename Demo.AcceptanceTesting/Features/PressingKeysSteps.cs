using Bumblebee.Extensions;
using Bumblebee.Setup;
using Bumblebee.Setup.DriverEnvironments;
using Demo.AcceptanceTesting.Pages;
using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Demo.AcceptanceTesting.Features
{
	[Binding]
	public class PressingKeysSteps
	{
		[Given(@"I enter the keypress page")]
		public void GivenIEnterTheKeypressPage()
		{
			Threaded<Session>
				.With<InternetExplorer>()
				.NavigateTo<KeyPressPage>(string.Format("{0}/{1}", NancyHostSetup.BaseUrl, "Content/KeyPressPage.html"));
		}

		[When(@"I press both control and space together")]
		public void WhenIPressBothControlAndSpaceTogether()
		{
			WhenIPress(Keys.Control + Keys.Space);
		}

		[When(@"I press both control and c together")]
		public void WhenIPressBothControlAndCTogether()
		{
			WhenIPress(Keys.Control + "C");
		}

		private void WhenIPress(string text)
		{
			Threaded<Session>
				.CurrentBlock<KeyPressPage>()
				.EntryField.EnterText(text);
		}

		[Then(@"the message should be '(.*)'")]
		public void ThenTheMessageShouldBeTrue(string message)
		{
			Threaded<Session>
				.CurrentBlock<KeyPressPage>()
				.VerifyThat(p => p.Message.Should().Be(message));
		}
	}
}
