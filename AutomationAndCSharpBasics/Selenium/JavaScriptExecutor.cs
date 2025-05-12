using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationAndCSharpBasics.Selenium;

public class JavaScriptExecutor
{
    [Test]
    public void JavaScriptExecutorTest()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
        IJavaScriptExecutor js = (IJavaScriptExecutor) driver;
        js.ExecuteScript("window.scrollBy(0,500)");
        js.ExecuteScript("document.querySelector(\".tableFixHead\").scrollTop=500"); //----Scrolling on a targetted element
        driver.Close();
    }
}
