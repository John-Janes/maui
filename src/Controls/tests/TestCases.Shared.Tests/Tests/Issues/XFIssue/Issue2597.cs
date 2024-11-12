using NUnit.Framework;
using UITest.Appium;
using UITest.Core;

namespace Microsoft.Maui.TestCases.Tests.Issues;

public class Issue2597 : _IssuesUITest
{
	public Issue2597(TestDevice testDevice) : base(testDevice)
	{
	}

	public override string Issue => "Stepper control .IsEnabled doesn't work";

	[Test]
	[Category(UITestCategories.Stepper)]
	
	public void Issue2597Test()
	{

 		App.Tap("Increment");

		App.Tap("+");


		App.WaitForElement("Stepper value is 0");



 		App.Tap("Decrement");

		App.Tap("−");

		App.WaitForElement("Stepper value is 0");
	}
}