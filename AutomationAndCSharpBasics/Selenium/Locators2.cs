using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationAndCSharpBasics.Selenium;

public class Locators2
{
    [Test]
    public void LoginTest2()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
        driver.FindElement(By.XPath("//header/div/button[1]/following-sibling::button[1]")).Click();
        driver.FindElement(By.XPath("//header/div/button[1]/parent::div/button[2]")).Click();
        driver.Close();
    }
}
