using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV_2._3
{
    class EmailOutlook
    {
        const string OUTLOOKURL = "https://outlook.live.com/owa/";
        const string LOGIN = "TAT2020TASK2-3.1@outlook.com";
        const string PASSWORD = "ACCOUNT1PSWD";
        WebDriverWorker outlookWorker = new WebDriverWorker();
        public void ClickSignInButton()
        {
            outlookWorker.URL = OUTLOOKURL;
            outlookWorker.Waiter();
            IWebElement signInButton;
            signInButton = outlookWorker.GetWebDriver().FindElement(By.LinkText("Войти"));
            signInButton.Click();
            outlookWorker.Waiter();
        }
        public void InputLogin()
        {
            if (!outlookWorker.URL.Contains("login"))
            {
                throw new Exception("Url doesn't conatains \"login\" ");
            }
            IWebElement loginField, buttonNext;
            loginField = outlookWorker.GetWebDriver().FindElement(By.Id("i0116"));
            buttonNext = outlookWorker.GetWebDriver().FindElement(By.Id("idSIButton9"));

            loginField.SendKeys(LOGIN);
            outlookWorker.Waiter();
            buttonNext.Click();
            outlookWorker.Waiter();
        }
        public void InputPassword()
        {
            IWebElement passwordField, signInButton;
            passwordField = outlookWorker.GetWebDriver().FindElement(By.Id("i0118"));
            signInButton = outlookWorker.GetWebDriver().FindElement(By.Id("idSIButton9"));

            passwordField.SendKeys(PASSWORD);
            outlookWorker.Waiter();
            signInButton.Click();
            outlookWorker.Waiter();
        }
        public void WriteNewMassage(string reciever, string subject, string message)
        {
            IWebElement newMassageButton, fieldTo, fieldSubject, fieldMessage, buttonSend;
            newMassageButton = outlookWorker.GetWebDriver().FindElement(By.Id("id__3"));
            newMassageButton.Click();
            fieldTo = outlookWorker.GetWebDriver().FindElement(By.
                ClassName("ms - BasePicker - input pickerInput_8d9d7e4e"));
            fieldSubject = outlookWorker.GetWebDriver().FindElement(By.
                Id("TextField161"));
            fieldMessage = outlookWorker.GetWebDriver().FindElement(By.
                ClassName("_4utP_vaqQ3UQZH0GEBVQe B1QSRkzQCtvCtutReyNZ _17ghdPL1NLKYjRvmoJgpoK _2s9KmFMlfdGElivl0o-GZb"));
            buttonSend = outlookWorker.GetWebDriver().FindElement(By.
                Id("ms-Button-flexContainer flexContainer-46")); 

            fieldTo.SendKeys(reciever);
            fieldSubject.SendKeys(subject);
            fieldMessage.SendKeys(message);
            buttonSend.Click();
        }
    }
}
