using System;
using Nancy.Hosting.Self;
using TechTalk.SpecFlow;

namespace Demo.AcceptanceTesting
{
	[Binding]
	public class NancyHostSetup
	{
		public const string BaseUrl = "http://localhost:1234";

		private static NancyHost _host;

		[BeforeTestRun]
		public static void BeforeTestRun()
		{
			_host = new NancyHost(new Uri(BaseUrl));
			_host.Start();
		}

		[AfterTestRun]
		public static void AfterTestRun()
		{
			_host.Stop();
			_host.Dispose();
		}
	}
}
