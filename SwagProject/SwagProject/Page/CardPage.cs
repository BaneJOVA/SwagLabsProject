using OpenQA.Selenium;
using SwagProject.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagProject.Page
{
    internal class CardPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        public IWebElement Checkaut => driver.FindElement(By.Id("checkout"));
        public IWebElement FirstName => driver.FindElement(By.Id("first-name"));
        public IWebElement LastName => driver.FindElement(By.Id("last-name"));
        public IWebElement ZiplCode => driver.FindElement(By.Id("postal-code"));
        public IWebElement ButonContinue => driver.FindElement(By.Id("continue"));
        public IWebElement Finish => driver.FindElement(By.Id("finish"));
        public IWebElement OrderFinished => driver.FindElement(By.CssSelector("#checkout_complete_container .complete-header"));
    }
}
