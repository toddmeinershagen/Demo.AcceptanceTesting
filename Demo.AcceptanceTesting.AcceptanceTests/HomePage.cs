using Coypu;

namespace Demo.AcceptanceTesting.AcceptanceTests
{
    public class HomePage : Page
    {
        public HomePage(BrowserSession browser)
            : base(browser)
        {}

        public BenefitsRequestPage InitiateBenefitsRequest()
        {
            Browser.ClickLink("Benefits Request");
            return new BenefitsRequestPage(Browser);
        }
    }
}