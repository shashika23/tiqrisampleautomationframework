﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EAAutoFramework.Base
{
    public abstract class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(DriverContext.Driver, this);
        }


    }
}
