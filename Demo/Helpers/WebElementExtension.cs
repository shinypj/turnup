using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Helpers
{
    public static class WebElementExtension
    {
        public static void WaitForElement(this IWebElement webElement,TimeSpan timeSpan)
        {
            var wait = new WebDriverWait(CommonDriver.driver, timeSpan);
            wait.Until(ExpectedConditions.ElementToBeClickable(webElement));
        }
    }
}
