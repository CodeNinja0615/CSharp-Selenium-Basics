using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationAndCSharpBasics.Selenium;

public class WindowHandle
{
    [Test]
    public void WindowHandleTest()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Navigate().GoToUrl("https://rahulshettyacademy.com/loginpagePractise/");
        driver.FindElement(By.ClassName("blinkingText")).Click();
        String[] windows = driver.WindowHandles.ToArray();
        String firstWindow = windows[0];
        String secondWindow = windows[1];
        driver.SwitchTo().Window(secondWindow);
        String text = driver.FindElement(By.CssSelector("a[href*='mentor@']")).Text;
        TestContext.Out.WriteLine(text);
        driver.SwitchTo().Window(firstWindow);
        driver.FindElement(By.Id("username")).SendKeys("akhtarsameer743#gmail.com");
        driver.Close();
    }
}
