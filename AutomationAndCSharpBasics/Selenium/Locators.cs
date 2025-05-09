using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationAndCSharpBasics.Selenium;

public class Locators
{
    [Test]
    public void TestLogin()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Navigate().GoToUrl("https://rahulshettyacademy.com/locatorspractice/");
        driver.FindElement(By.LinkText("Forgot your password?")).Click();
        Thread.Sleep(2000);
        driver.FindElement(By.CssSelector(".reset-pwd-btn")).Click();
        string infoMessage = driver.FindElement(By.CssSelector(".infoMsg")).Text;
        String password = infoMessage.Split("'")[1];
        driver.FindElement(By.ClassName("go-to-login-btn")).Click();
        driver.FindElement(By.Id("inputUsername")).SendKeys("Sameer");
        driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys(password);
        Thread.Sleep(2000);
        driver.FindElement(By.CssSelector("#chkboxOne")).Click();
        driver.FindElement(By.CssSelector("#chkboxTwo")).Click();
        driver.FindElement(By.XPath("//button[normalize-space()='Sign In']")).Click();
        Thread.Sleep(2000);
        String confirmationMsg = driver.FindElement(By.CssSelector(".login-container")).Text;
        TestContext.Out.WriteLine(confirmationMsg);
        Assert.That(confirmationMsg, Does.Contain("Sameer"));
        driver.Close();
    }
}
