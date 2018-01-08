using GitSample;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSample
{
    class SearchPage
    {
        public SearchPage()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        [FindsBy(How = How.Name, Using = "btnK")]
        public IWebElement searchButton { get; set; }

        [FindsBy(How = How.Id, Using = "lst-ib")]
        public IWebElement searchBox { get; set; }

       

        public void GoogleSearch(string searchText)
        {
            searchBox.EnterText(searchText);
            System.Threading.Thread.Sleep(10000);
            searchButton.Click();
            System.Threading.Thread.Sleep(5000);

        }


    }
}
