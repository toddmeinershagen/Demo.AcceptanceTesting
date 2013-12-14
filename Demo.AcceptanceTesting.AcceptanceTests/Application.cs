using Coypu;

namespace Demo.AcceptanceTesting.AcceptanceTests
{
    public class Application : Page
    {
        public Application(BrowserSession browser)
            : base(browser)
        {
        }

        public HomePage Login(string username, string password)
        {
            Browser.Visit("https://eligibility.medassets.com");
            Browser.FillIn("UserName").With(username);
            Browser.FillIn("Password").With(password);
            Browser.Check("EnableSSO");
            Browser.ClickButton("signIn");

            return new HomePage(Browser);
        }
    }
}