using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AppTests.pages
{
    class ReactPage
    {
        public string GetSession(IOSDriver<IOSElement> driver)
        {
            string selectorButton = "label CONTAINS 'Avançar'";
            string selectorSessionId = "label BEGINSWITH 'Session_Id'";
            string enviado = "label BEGINSWITH 'Enviado'";

            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

            try
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent()).Dismiss();
            }
            catch
            {

            }

            IOSElement sessionId = (IOSElement)wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.IosNSPredicate(selectorSessionId)));

            IReadOnlyList<IOSElement> elements = (IReadOnlyList<IOSElement>)driver.FindElements(MobileBy.IosNSPredicate(selectorButton));

            foreach (IOSElement element in elements)
            {
                try
                {
                    element.Click();
                }
                catch
                {

                }
            }

            IOSElement lblEnviado = (IOSElement)wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.IosNSPredicate(enviado)));

            return sessionId.Text.Trim().Substring(12, 36);
        }
    }
}
