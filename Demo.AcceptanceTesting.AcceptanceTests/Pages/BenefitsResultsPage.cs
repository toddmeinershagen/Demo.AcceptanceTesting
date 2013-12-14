using Coypu;

namespace Demo.AcceptanceTesting.AcceptanceTests.Pages
{
    public class BenefitsResultsPage : Page
    {
        public BenefitsResultsPage(BrowserSession browser)
            : base(browser)
        {}

        public void ShouldHaveCoverageType(string coverageType)
        {
            Browser.HasContent(coverageType);
        }
    }
}