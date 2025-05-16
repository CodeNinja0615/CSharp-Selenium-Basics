using System.Configuration;

namespace AutomationAndCSharpBasics.Selenium;

public class ConfigManager
{
    [Test, Category("Sanity")]
    public void ConfigManagerTest()
    {
        string? browserName = TestContext.Parameters["browserName"];
        if (browserName == null)
        {
            browserName = ConfigurationManager.AppSettings["browser"];
        }
        TestContext.Out.WriteLine(browserName);
        Console.WriteLine(browserName);
    }
}
