using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomationAndCSharpBasics.Selenium;

public class DropDown
{
    [Test]
    public void DropDownTest()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Navigate().GoToUrl("https://rahulshettyacademy.com/dropdownsPractise/");
        IWebElement currencyDrdo = driver.FindElement(By.CssSelector("select[name*='DropDownListCurrency']"));
        SelectElement drdo = new SelectElement(currencyDrdo);
        drdo.SelectByValue("INR");
        driver.FindElement(By.Id("divpaxinfo")).Click();
        driver.FindElement(By.CssSelector("#divChild #hrefIncChd")).Click();
        driver.FindElement(By.Id("btnclosepaxoption")).Click();
        driver.FindElement(By.XPath("//div[@id='familyandfriend']/input[@type='checkbox']")).Click();
        driver.FindElement(By.Id("ctl00_mainContent_ddl_originStation1_CTXT")).Click();
        driver.FindElement(By.XPath("//div[@id='ctl00_mainContent_ddl_originStation1_CTNR']//li/a[@text='Bengaluru (BLR)']")).Click();
        driver.FindElement(By.XPath("//div[@id='ctl00_mainContent_ddl_destinationStation1_CTNR']//li/a[@text='Guwahati (GAU)']")).Click();
        driver.FindElement(By.Id("autosuggest")).SendKeys("Ind");
        Thread.Sleep(2000);
        IList<IWebElement> suggestions = driver.FindElements(By.CssSelector(".ui-menu-item a"));
        foreach (IWebElement suggestion in suggestions)
        {
            String country = suggestion.Text;
            if (country.Equals("India"))
            {
                suggestion.Click();
            }
        }
        driver.FindElement(By.CssSelector("#ctl00_mainContent_view_date1")).Click();
        driver.FindElement(By.CssSelector(".ui-state-default.ui-state-active")).Click();
        driver.FindElement(By.CssSelector("#ctl00_mainContent_view_date2")).Click();
        driver.FindElement(By.CssSelector(".ui-state-default.ui-state-active")).Click();
        driver.FindElement(By.XPath("//a[text()='Special Assistance']")).Click();
        driver.FindElement(By.CssSelector("#SpecialAssistanceWindow")).Click();
        driver.FindElement(By.Name("ctl00$mainContent$btn_FindFlights")).Click();
        IAlert alert = driver.SwitchTo().Alert();
        TestContext.Out.WriteLine(alert.Text);
        alert.Accept();
        driver.Close();
    }
}
