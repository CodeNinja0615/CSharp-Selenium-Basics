using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationAndCSharpBasics.Selenium;

public class BasicAuth
{
    
    [Test]
    public void BasicAuthTest()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Navigate().GoToUrl("https://admin:admin@the-internet.herokuapp.com/basic_auth"); //---https://id:pass@xyz.com
    }
}
