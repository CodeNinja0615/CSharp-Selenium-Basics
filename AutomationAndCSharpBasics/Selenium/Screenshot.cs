using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationAndCSharpBasics.Selenium;

public class ScreenshotTestClass
{
    [Test]
    public void ScreenshotTest()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Navigate().GoToUrl("https://www.amazon.in/");
        Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

        string projectRoot = AppDomain.CurrentDomain.BaseDirectory;
        string? solutionRoot = Directory.GetParent(projectRoot)?.Parent?.Parent?.Parent?.FullName;
        // Create "Screenshots" folder if it doesn't exist
        string screenshotsDir = Path.Combine(solutionRoot, "Screenshots");
        Directory.CreateDirectory(screenshotsDir);
        // Generate timestamped filename
        string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        string filePath = Path.Combine(screenshotsDir, $"Screenshot_{timestamp}.png");
        // string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Screenshot.png"); //--Saves in bin
        ss.SaveAsFile(filePath);
        driver.Close();
    }
}
