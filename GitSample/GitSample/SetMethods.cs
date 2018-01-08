using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace GitSample
{
    public static class PortalSetMethods
    {
        //Enter Text
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //Click
        public static void Click(this IWebElement element)
        {
            element.Click();
        }

        //Dropdown Control
        public static void Dropdown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
