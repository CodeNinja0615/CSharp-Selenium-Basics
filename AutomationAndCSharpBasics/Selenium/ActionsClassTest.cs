using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace AutomationAndCSharpBasics.Selenium;

public class ActionsClassTest
{
    [Test]
    public void ActionsClassTestign()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Navigate().GoToUrl("https://www.amazon.in/");
        Actions action = new Actions(driver);
        IWebElement moveTo = driver.FindElement(By.XPath("//span[@class='nav-line-2 ' and normalize-space()='Account & Lists']"));
        IWebElement searchBox = driver.FindElement(By.Id("twotabsearchtextbox"));
        action.MoveToElement(searchBox).Click().KeyDown(Keys.Shift).SendKeys("hello")
        .KeyUp(Keys.Shift).DoubleClick().Build().Perform();
        action.MoveToElement(moveTo).ContextClick().Build().Perform();
        driver.Close();
    }
}
