using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationAndCSharpBasics.Selenium;

public class Selenium4Demo
{
    [Test]
    public void Selenium4Test()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
        driver.SwitchTo().NewWindow(WindowType.Window);
        IList<String> windows = driver.WindowHandles; //---can also use .toArray()
        String firstWindow = windows[0];
        String secondWindow = windows[1];
        driver.SwitchTo().Window(secondWindow);
        driver.Navigate().GoToUrl("https://rahulshettyacademy.com/");
        String text = driver.FindElement(By.CssSelector(".price-title h2")).Text;
        driver.SwitchTo().Window(firstWindow);
        IWebElement name = driver.FindElement(By.CssSelector("input[name='name']:nth-child(2)"));
        name.SendKeys(text);

        //------- Get Height & Width
        int height = name.Size.Height;
        int width = name.Size.Width;

        Console.WriteLine("Height: "+ height +" Width: "+ width);
        driver.Quit();
    }
}
