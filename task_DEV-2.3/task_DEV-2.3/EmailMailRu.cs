using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV_2._3
{
    class EmailMailRu
    {
        WebDriverWorker mailruWorker;
        const string mailru_URL = "https://mail.ru/";
        const string LOGIN = "TAT2020ACC2@mail.ru";
        const string PASSWORD = "ACCOUNT2PSWD";
        static Dictionary<string, string> ElementToXPath = new Dictionary<string, string>();
        public EmailMailRu()
        {
            mailruWorker = new WebDriverWorker();
            mailruWorker.URL = mailru_URL;

            ElementToXPath.Add("fieldLogin", "//*[@id='mailbox:login']");
            ElementToXPath.Add("buttonConfirmLogin", "//*[@id=\"mailbox:submit\"]/input");
            ElementToXPath.Add("fieldPassword", "//*[@id=\"mailbox:password\"]");
            ElementToXPath.Add("buttonConfirmPassword", "//*[@id=\"mailbox:submit\"]/input");
            ElementToXPath.Add("newMassageButton", "//*[@id=\"app-canvas\"]/div/div[1]/div[1]/div/div[2]/div[1]/div/div/div/div[1]/div/a/span");
            ElementToXPath.Add("fieldReciever", "/html/body/div[14]/div[2]/div/div[1]/div[2]/div[3]/div[2]/div/div/div[1]/div/div[2]/div/div/label/div/div/input");
            ElementToXPath.Add("fieldSubject", "/html/body/div[14]/div[2]/div/div[1]/div[2]/div[3]/div[3]/div[1]/div[2]/div/input");
            ElementToXPath.Add("fieldMessage", "/html/body/div[14]/div[2]/div/div[1]/div[2]/div[3]/div[5]");
            ElementToXPath.Add("buttonSendMail", "/html/body/div[14]/div[2]/div/div[2]/div[1]/span[1]/span");
        }
        IWebElement RegisterElement(string element)
        {
            ElementToXPath.TryGetValue(element, out string xpath);
            return mailruWorker.WaitUntilElementFound(xpath);
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
