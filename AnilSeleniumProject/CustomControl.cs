using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnilSeleniumProject
{
    class CustomControl: DriverHelper
    {
        public void ComboBox(string controlName, string value)
        {
            IWebElement comboField = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            comboField.Clear();
            comboField.SendKeys(value);
            Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//ul/li[1]")).Click();
        }

    }
}
