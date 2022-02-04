using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AnilSeleniumProject
{
    public class Tests : DriverHelper
    {
        // public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Mango");
            //Driver.FindElement(By.XPath("//input[@type='checkbox']/following::div[text()='Celery']")).Click();
            Assert.Pass();
            CustomControl control = new CustomControl();
            control.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");
        }
    }
}