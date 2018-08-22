using Demo.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Page
{
	class LoginPage
	{

		public LoginPage()
		{
			PageFactory.InitElements(CommonDriver.driver, this);
		}

		[FindsBy(How = How.XPath, Using = "//*[@id='UserName']")]
		private IWebElement username { set; get; }

		[FindsBy(How = How.XPath, Using = "//*[@id='Password']")]
		private IWebElement password { set; get; }

		[FindsBy(How = How.XPath, Using = "//*[@id='loginForm']/form/div[3]/input[1]")]
		private IWebElement login { set; get; }


		public void LoginSteps()
		{
            //Go to Url
            //CommonDriver.driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            CommonDriver.driver.Navigate().GoToUrl(ExcelLibHelpers.ReadData(2, "url"));

            //Enter USer Name

            //username.SendKeys("hari");
            username.SendKeys(ExcelLibHelpers.ReadData(2,"username"));

            //Enter Password

            password.SendKeys(ExcelLibHelpers.ReadData(2,"password"));

			// Enter Login

			login.Click();

            ///Check if home page is displayed
            //if (CommonDriver.driver.FindElement(By.XPath("/html/body/div[3]/div/a")).Text == "TurnUp")

            //{
            //	Console.WriteLine("Logged in Successfully,Test Pased");
            //}
            //else

            //{
            //	Console.WriteLine("Login fail");
            //}

            var homePageText = CommonDriver.driver.FindElement(By.XPath("/html/body/div[3]/div/a")).Text;
            Assert.AreEqual("TurnUp", homePageText);
			
		}

	}
}
