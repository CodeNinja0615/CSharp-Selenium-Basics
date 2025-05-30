using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationAndCSharpBasics.Selenium;

public class UploadDownload
{
    [Test]
    public void UploadDownloadTest()
    {
        // Set the desired download path
        string projectRoot = AppDomain.CurrentDomain.BaseDirectory;
        string? downloadPath = Path.Combine(Directory.GetParent(projectRoot)!.Parent!.Parent!.Parent!.FullName, "Downloads");
        // Create the folder if it doesn't exist
        if (!Directory.Exists(downloadPath))
        {
            Directory.CreateDirectory(downloadPath);
        }
        // Configure ChromeOptions
        ChromeOptions options = new ChromeOptions();
        options.AddUserProfilePreference("download.default_directory", downloadPath);
        options.AddUserProfilePreference("download.prompt_for_download", false);
        options.AddUserProfilePreference("download.directory_upgrade", true);
        options.AddUserProfilePreference("safebrowsing.enabled", true);
        IWebDriver driver = new ChromeDriver(options);
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Navigate().GoToUrl("https://rahulshettyacademy.com/upload-download-test/index.html");
        driver.FindElement(By.Id("downloadButton")).Click();
        IWebElement upload = driver.FindElement(By.Id("fileinput"));
        Thread.Sleep(5000); //--can replace with a method to wait till file gets downloaded
        upload.SendKeys(downloadPath + "/download.xlsx");
        File.Delete(downloadPath+"/download.xlsx");
        driver.Quit();
    }
}
