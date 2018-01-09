using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSample
{
    // enum is not used anywhere in the scripts
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        XPath,

    }

}
class Properties
{
    public static IWebDriver driver { get; set; }

}
