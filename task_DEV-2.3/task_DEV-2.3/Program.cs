using System;


namespace task_DEV_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailOutlook emailOutlook = new EmailOutlook();
            emailOutlook.ClickSignInButton();
            emailOutlook.InputLogin();
            emailOutlook.InputPassword();

            EmailMailRu emailMailRu = new EmailMailRu();
            emailMailRu.InputLogin();
            emailMailRu.InputPassword();

        }
    }
}
