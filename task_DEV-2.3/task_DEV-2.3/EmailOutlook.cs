using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;
using OpenQA.Selenium.Support.UI;

namespace task_DEV_2._3
{
    class EmailOutlook
    {
        WebDriverWorker outlookWorker;
        const string OUTLOOK_URL = "https://outlook.live.com/owa/";
        const string LOGIN = "TAT2020TASK2-3.1@outlook.com";
        const string PASSWORD = "ACCOUNT1PSWD";
        static Dictionary<string, string> ElementToXPath = new Dictionary<string, string>();
        public EmailOutlook()
        {
            outlookWorker = new WebDriverWorker();
            outlookWorker.URL = OUTLOOK_URL;

            ElementToXPath.Add("buttonSignIn", "/html/body/header/div/aside/div/nav/ul/li[2]/a");
            ElementToXPath.Add("fieldLogin", "//*[@id=\"i0116\"]");
            ElementToXPath.Add("buttonConfirmLogin", "//*[@id=\"idSIButton9\"]");
            ElementToXPath.Add("fieldPassword", "//*[@id=\"i0118\"]");
            ElementToXPath.Add("buttonConfirmPassword", "//*[@id=\"idSIButton9\"]");
            ElementToXPath.Add("newMassageButton", "//*[@id=\"id__3\"]");
            ElementToXPath.Add("fieldReciever", "//*[@id=\"app\"]/div/div[2]/div[1]/div[1]/div[3]/div[2]/div/div[3]/div[1]/div/div/div/div[1]/div[1]/div[1]/div/div[1]/div/div/div/div/div[1]/div/div/input");
            ElementToXPath.Add("fieldSubject", "//*[@id=\"TextField255\"]");
            ElementToXPath.Add("fieldMessage", "//*[@id=\"app\"]/div/div[2]/div[1]/div[1]/div[3]/div[2]/div/div[3]/div[1]/div/div/div/div[1]/div[2]/div[1]");
            ElementToXPath.Add("buttonSendMail", "//*[@id=\"app\"]/div/div[2]/div[1]/div[1]/div[3]/div[2]/div/div[3]/div[1]/div/div/div/div[1]/div[3]/div[2]/div[1]/button[1]/span");
        }
        IWebElement RegisterElement(string element)
        {
            ElementToXPath.TryGetValue(element, out string xpath);
            return outlookWorker.WaitUntilElementFound(xpath);
        }
        public void ClickSignInButton()
        {
            IWebElement buttonSignIn = RegisterElement(nameof(buttonSignIn));
            buttonSignIn.Click();
        }
        public void InputLogin()
        {
            IWebElement fieldLogin, buttonConfirmLogin;

            fieldLogin = RegisterElement(nameof(fieldLogin));
            fieldLogin.SendKeys(LOGIN);

            buttonConfirmLogin = RegisterElement(nameof(buttonConfirmLogin));
            buttonConfirmLogin.Click();
        }
        public void InputPassword()
        {
            IWebElement fieldPassword, buttonConfirmPassword;

            fieldPassword = RegisterElement(nameof(fieldPassword));
            fieldPassword.SendKeys(PASSWORD);

            buttonConfirmPassword = RegisterElement(nameof(buttonConfirmPassword));
            buttonConfirmPassword.Click();
        }
        public void WriteNewMassage(string reciever, string subject, string message)
        {
            IWebElement newMassageButton, fieldReciever, fieldSubject, fieldMessage, buttonSendMail;

            newMassageButton = RegisterElement(nameof(newMassageButton));
            newMassageButton.Click();

            fieldReciever = RegisterElement(nameof(fieldReciever));
            fieldSubject = RegisterElement(nameof(fieldSubject));
            fieldMessage = RegisterElement(nameof(fieldMessage));
            buttonSendMail = RegisterElement(nameof(buttonSendMail));



            fieldReciever.SendKeys(reciever);
            fieldSubject.SendKeys(subject);
            fieldMessage.SendKeys(message);
            buttonSendMail.Click();
        }
    }
}
