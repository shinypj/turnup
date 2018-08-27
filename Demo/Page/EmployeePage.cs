using Demo.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Demo.Page
{
    class EmployeePage
	{
		

		public EmployeePage()
		{
			PageFactory.InitElements(CommonDriver.driver,this);
		}

		[FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/ul/li[5]/a")]
		private IWebElement Administrator { set; get; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a")]
		private IWebElement Employee { set; get; }

		[FindsBy(How = How.XPath, Using = "//*[@id='container']/p/a")]
		private IWebElement Create { set; get; }

        internal void ValidateEmployee()
        {
            // Thread.Sleep(3000);
            //var wait = new WebDriverWait(CommonDriver.driver,TimeSpan.FromSeconds(10));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"container\"]/p/a")));
            //wait.Until(ExpectedConditions.ElementToBeClickable(btnCreate));

            // btnCreate.WaitForElement(TimeSpan.FromSeconds(10));
            btnCreate.WaitForElement(TimeSpan.FromSeconds(10));

            while (true)
            {
                var i = 1;
                while (i <= 10)
                {
                    // identify 1st row of table. Then extact the text and assign to a variable
                    var name = CommonDriver.driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]")).Text;
                    //compare the text with the expected text. Industry
                    if (name == "Industry")
                    {
                        Console.WriteLine("Test passed");
                        return;
                    }
                    i++;
                }
                var btnNext = CommonDriver.driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[3]/span"));
                btnNext.Click();
            }
        }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"container\"]/p/a")]
        IWebElement btnCreate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Name']")]
		private IWebElement Name { set; get; }

		[FindsBy(How = How.XPath, Using = "//*[@id='Username']")]
		private IWebElement userName { set; get; }

		[FindsBy(How = How.XPath, Using = "//*[@id='ContactDisplay']")]
		private IWebElement Contact { set; get; }

		[FindsBy(How = How.XPath, Using = "//*[@id='Password']")]
		private IWebElement Password { set; get; }

		[FindsBy(How = How.XPath, Using = "//*[@id='RetypePassword']")]
		private IWebElement RetypePassword { set; get; }

		[FindsBy(How = How.XPath, Using = "//*[@id='SaveButton']")]
		private IWebElement Save { set; get; }

		[FindsBy(How = How.XPath, Using = "//*[@id='container']/div/a")]
		private IWebElement BackToList { set; get; }

		[FindsBy(How = How.XPath, Using = "//*[@id='usersGrid']/div[4]/a[4]")]
		private IWebElement lastPage { set; get; }

		[FindsBy(How = How.XPath, Using = "//*[@id='usersGrid']")]
		internal IWebElement Edit{ set; get; }


		public void Addemployee()
		{
			//Administrator			
			Administrator.Click();
            //Administrator.WaitForElement(TimeSpan.FromSeconds(10));

            //Go to Employee			
            Employee.WaitForElement(TimeSpan.FromSeconds(3));

            Employee.Click();


			//Crate new Employee

			Create.Click();

			Name.SendKeys("Industry");

			userName.SendKeys("Connect23");

			Contact.SendKeys("0123456789");

			Password.SendKeys("Abcd@1234)");

			RetypePassword.SendKeys("Abcd@1234)");

			Save.Click();

			BackToList.Click();

			//lastPage.Click();

            //Validation
			if (CommonDriver.driver.FindElement(By.XPath("//*[@id='container']/p/a")).Text == "Create")
			{
				Console.WriteLine("Employee Created Successfully");
			}
			else
			{
				Console.WriteLine("Fail to create Employee");

			}
		}
		public void Deleteemployee()
		{
		}

	}

}
