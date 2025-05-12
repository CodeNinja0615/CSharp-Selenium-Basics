using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationAndCSharpBasics.Selenium;

public class RelativeLocators
{

    [Test]
    public void RelativeLocatorsTest()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
        String text = driver.FindElement(RelativeBy.WithLocator(By.XPath("//label[text()='Name']")).Above(By.CssSelector("input[name='name']:nth-child(2)"))).Text;
        TestContext.Out.WriteLine(text);
        driver.Quit();
        
    }
}
