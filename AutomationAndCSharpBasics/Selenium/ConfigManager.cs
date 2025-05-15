using System.Configuration;

namespace AutomationAndCSharpBasics.Selenium;

public class ConfigManager
{
    [Test]
    public void ConfigManagerTest()
    {
        String browserName = ConfigurationManager.AppSettings["browser"];
        TestContext.Out.WriteLine(browserName);
    }
}
