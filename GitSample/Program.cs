using GitSample;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSampleTest
{
    class Program
    {

        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            Properties.driver = new ChromeDriver(@"C:\Program Files\Chrome");
            //Navigate to Google Page test
            Properties.driver.Navigate().GoToUrl("https://www.google.com/");

        }


        [Test, Order(1)]
        public void SearchTest()
        {
            SearchPage page = new SearchPage();
            page.GoogleSearch("test");

        }



        [TearDown]
        public void CleanUp()
        {
           Properties.driver.Close();
         }
    }
}
