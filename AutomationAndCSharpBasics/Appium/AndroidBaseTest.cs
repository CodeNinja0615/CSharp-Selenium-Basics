using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Service;
namespace AutomationAndCSharpBasics.Appium;

[TestFixture]
public class AndroidBaseTest
{
    public AppiumLocalService? service;
    public AndroidDriver? driver;
    public string packageName = "com.androidsample.generalstore";
    
    /// <summary>
    /// 
    /// </summary>
    [OneTimeSetUp]
    public void ConfigureAppiumMobile()
    {
        string deviceName = "emulator-5554";
        string platformName = "Android";

        if (platformName.Equals("Android", StringComparison.OrdinalIgnoreCase))
        {
            var environment = new Dictionary<string, string>();
            environment["ANDROID_HOME"] = "/Users/sameerakhtar/Library/Android/sdk";
            environment["ANDROID_SDK_ROOT"] = "/Users/sameerakhtar/Library/Android/sdk";

            service = new AppiumServiceBuilder()
                .WithAppiumJS(new FileInfo("/opt/homebrew/lib/node_modules/appium/build/lib/main.js"))
                .UsingDriverExecutable(new FileInfo("/opt/homebrew/opt/node@22/bin/node"))
                .WithIPAddress("127.0.0.1")
                .UsingPort(4723)
                .WithEnvironment(environment)
                .Build();

            service.Start();

            var options = new AppiumOptions();
            options.PlatformName = platformName;
            options.DeviceName = deviceName;
            options.AutomationName = "UiAutomator2";
            options.AddAdditionalAppiumOption("noReset", true);
            options.AddAdditionalAppiumOption("appWaitForLaunch", true);
            options.AddAdditionalAppiumOption("gpsEnabled", true);
            options.AddAdditionalAppiumOption("autoGrantPermissions", true);

            driver = new AndroidDriver(new Uri("http://127.0.0.1:4723"), options);
        }
    }


    [SetUp]
    public void BeforeTest()
    {
        driver?.ActivateApp(packageName);
    }

    [TearDown]
    public void AfterTest()
    {
        driver?.TerminateApp(packageName);
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        driver?.Dispose();
        service?.Dispose();
    }
}
