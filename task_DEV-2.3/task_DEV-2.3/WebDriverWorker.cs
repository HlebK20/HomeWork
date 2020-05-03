using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;

namespace task_DEV_2._3
{
    class WebDriverWorker
    {
        IWebDriver driver;
        TimeSpan TIME_TO_WAIT = TimeSpan.FromSeconds(30);
        public WebDriverWorker()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TIME_TO_WAIT;
        }

        public IWebElement FindElementByText(string name)
        {
            IWebElement webElement;
            return webElement = driver.FindElement(By.LinkText(name));
        }
        public IWebDriver GetWebDriver()
        {
            return driver;
        }
        public string URL
        {
            get
            {
                return driver.Url;
            }
            set
            {
                driver.Url = value;
            }
        }
        public void Waiter()
        {
            WebDriverWait webDriverWait = new WebDriverWait(driver,TIME_TO_WAIT);
            webDriverWait.Message = "Waiting...";
            
        }
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
