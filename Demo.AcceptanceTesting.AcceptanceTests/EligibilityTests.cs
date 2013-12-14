using System;
using Coypu;
using Coypu.Drivers;
using Demo.AcceptanceTesting.AcceptanceTests.Pages;
using NUnit.Framework;

namespace Demo.AcceptanceTesting.AcceptanceTests
{
    [TestFixture]
    public class EligibilityTests
    {
        [Test]
        public void given_valid_subscriber_information_when_submitting_request_for_eligibility_for_subscriber_should_return_coverage_type()
        {
            var configuration = new SessionConfiguration
                {
                    Browser = Browser.Chrome
                };

            using (var browser = new BrowserSession(configuration))
            {
                var application = new Application(browser);
                application
                    .Login(@"medassets\tmeinershagen", "{enter password}")
                    .InitiateBenefitsRequest()
                    .SubmitRequest("Todd", "Meinershagen", "U4742976001", new DateTime(1972, 11, 23), "CIGNA", "patient-type-subscriber")
                    .ShouldHaveCoverageType("Choice Fund HSA Open Access Plus");
            }
        }
    }
}
