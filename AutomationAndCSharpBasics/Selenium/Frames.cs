using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace AutomationAndCSharpBasics.Selenium;

public class Frames
{
    [Test]
    public void FramesTest()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Navigate().GoToUrl("https://jqueryui.com/droppable/");
        IWebElement frame = driver.FindElement(By.CssSelector(".demo-frame"));
        driver.SwitchTo().Frame(frame);
        Actions action = new Actions(driver);
        action.DragAndDrop(driver.FindElement(By.Id("draggable")), driver.FindElement(By.Id("droppable"))).Build().Perform();
        driver.SwitchTo().DefaultContent();
        driver.FindElement(By.XPath("//a[contains(text(),'Resizable')]")).Click();
        driver.Close();
    }
}
