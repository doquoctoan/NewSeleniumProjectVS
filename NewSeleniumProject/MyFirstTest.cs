﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSeleniumProject
{
    public class MyFirstTest
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void myFirstTest()
        {
            driver.Navigate().GoToUrl("http://www.swtestacademy.com");

            Assert.AreEqual("SW Test Academy - Software Test Academy", driver.Title);

            driver.Close();

            driver.Quit();
        }
    }
}