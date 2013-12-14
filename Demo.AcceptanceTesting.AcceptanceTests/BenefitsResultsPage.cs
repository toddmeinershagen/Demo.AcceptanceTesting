using Coypu;

namespace Demo.AcceptanceTesting.AcceptanceTests
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