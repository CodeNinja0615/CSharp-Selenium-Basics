using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomationAndCSharpBasics.Selenium;

public class ExplicitWait
{
    [Test]
    public void ExplicitWaitTest()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_loading/1");
        driver.FindElement(By.XPath("//button[text()='Start']")).Click();
        By element = By.XPath("//h4[normalize-space()='Hello World!']");
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(element));
        driver.Close();
    }
}
