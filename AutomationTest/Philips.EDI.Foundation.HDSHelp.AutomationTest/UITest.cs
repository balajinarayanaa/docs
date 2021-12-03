using Microsoft.VisualStudio.TestTools.UnitTesting;
using Driver.UI.Interfaces;
using Driver.UI.Selenium;
using Reporters;
using Utilities;
using Utilities.Enums;

namespace Philips.EDI.Foundation.HDSHelp.AutomationTest
{
    [TestClass]
    public class UITest
    {
        [TestInitialize]
        public void BeforeTest()
        {
            ProcessUtilities.KillChromeDriver();
        }

        [TestMethod]
        public void LaunchingAndClickingonGetStarted()
        {
            ValidateOverviewPage();
        }

        public void ValidateOverviewPage()
        {
            IWebDriverUi _webdriver = new SeleniumDriver(Driver.Enums.BrowserType.Chrome, "https://hds-help.netlify.app/", null);
            object getStartedButton = _webdriver.FindElementByClassName("btn-default");
            _webdriver.Click(getStartedButton);
            object overViewText = _webdriver.FindElementByClassName("page-header");
            string text = _webdriver.GetText(overViewText);
            AssertTest.IsTrue(text.ToUpper().Equals("OVERVIEW"),"After clicking Get Started page displayed is not overview: "+text,"Get Started button was clicked and page was navigated to Overview Section");
        }
    }
}
