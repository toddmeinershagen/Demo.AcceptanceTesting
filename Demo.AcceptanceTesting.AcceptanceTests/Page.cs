using System;
using Coypu;

namespace Demo.AcceptanceTesting.AcceptanceTests
{
    public abstract class Page : IDisposable
    {
        protected readonly BrowserSession Browser;

        protected Page(BrowserSession browser)
        {
            Browser = browser;
        }

        public void Dispose()
        {
            Browser.Dispose();
        }
    }
}