using System;
using Coypu;

namespace Demo.AcceptanceTesting.AcceptanceTests.Pages
{
    public class BenefitsRequestPage : Page
    {
        public BenefitsRequestPage(BrowserSession browser)
            : base(browser)
        {}

        public BenefitsResultsPage SubmitRequest(string firstName, string lastName, string subscriberId, DateTime birthDate,
                                                 string payerName, string patientRelation)
        {
            Browser.FillIn("BenefitSearch-FirstName").With(firstName);
            Browser.FillIn("BenefitSearch-LastName").With(lastName);
            Browser.FillIn("BenefitSearch-SubscriberId").With(subscriberId);
            Browser.FillIn("BenefitSearch-BirthDate").With(birthDate.ToShortDateString());
            Browser.FillIn("payer_input").With(payerName);
            Browser.Choose(patientRelation);
            Browser.ClickButton("SearchEligibility");

            return new BenefitsResultsPage(Browser);
        }
    }
}