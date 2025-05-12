using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationAndCSharpBasics.Selenium;

public class BrowserOptions
{
    [Test]
    public void BrowserOptionsTest()
    {
        ChromeOptions options = new ChromeOptions();
        options.AcceptInsecureCertificates = true; //----SSL Cetificate ByPass
        options.AddArgument("--headless"); // Run in headless mode
        options.AddArgument("--incognito"); // Run in incognito mode
        IWebDriver driver = new ChromeDriver(options);
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Navigate().GoToUrl("https://expired.badssl.com/");
        driver.Close();
    }
}
