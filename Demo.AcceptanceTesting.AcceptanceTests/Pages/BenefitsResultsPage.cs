using Coypu;
using Coypu.Matchers;
using NUnit.Framework;

namespace Demo.AcceptanceTesting.AcceptanceTests.Pages
{
    public class BenefitsResultsPage : Page
    {
        public BenefitsResultsPage(BrowserSession browser)
            : base(browser)
        {}

        public void ShouldHaveCoverageType(string coverageType)
        {
            Assert.That(Browser, Shows.Content(coverageType));
        }
    }
}