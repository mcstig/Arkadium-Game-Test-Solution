﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestPorject_1.Usefull
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName,
        XPath
    }

    class PropertiesCollection
    {
        //Auto-implemented property
        public static IWebDriver driver { get; set; }
    }
}
