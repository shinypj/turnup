using Demo.Helpers;
using Demo.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class Program
	{
		[SetUp]
		public void login()
		{
			CommonDriver.driver = new ChromeDriver();
            ExcelLibHelpers.PopulateInCollection(@"C:\Users\aadhith.bose\Dropbox\Software Testing\Industry Connect\10 AutomationTesting\2018 Aug\Demo\Demo\Data\data.xlsx", "tc1");

            LoginPage loginObj = new LoginPage();
			loginObj.LoginSteps();

		}
        
		[Test]
		public void Addemployee()
		{
			var empObj = new EmployeePage();
			empObj.Addemployee();
            empObj.ValidateEmployee();
		}

		[Test]
		public void Editemployee()
		{
			EmployeePage empObj = new EmployeePage();
			//empObj.Editemployee();
		}

		[Test]
		public void Deleteemployee()
		{
			EmployeePage empObj = new EmployeePage();
			empObj.Deleteemployee();
		}

		[TearDown]
		public void finishTest()
		{
			//CommonDriver.driver.Quit();
		}



		static void Main(string[] args)
		{
						
		}
	}
}
