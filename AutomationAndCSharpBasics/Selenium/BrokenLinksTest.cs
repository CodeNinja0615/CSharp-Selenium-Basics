using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationAndCSharpBasics.Selenium;

public class BrokenLinksTest
{
    [Test]
    public void CheckBrokenLinks()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
        IWebElement footerSection = driver.FindElement(By.Id("gf-BIG"));
        IList<IWebElement> links = footerSection.FindElements(By.CssSelector("a[href*='http']"));

        List<string> brokenLinks = new List<string>();

        foreach (var link in links)
        {
            string? url = link.GetDomAttribute("href");

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "HEAD";

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    int statusCode = (int)response.StatusCode;
                    if (statusCode >= 400)
                    {
                        brokenLinks.Add($"Broken URL: {url} | Status Code: {statusCode}");
                    }
                }
            }
            catch (WebException ex)
            {
                brokenLinks.Add($"Broken URL: {url} | Exception: {ex.Message}");
            }
            catch (UriFormatException ex)
            {
                brokenLinks.Add($"Invalid URL: {url} | Exception: {ex.Message}");
            }
        }

        // Soft Assertion
        Assert.Multiple(() =>
        {
            foreach (var brokenLink in brokenLinks)
            {
                Assert.Fail(brokenLink);
            }
        });
        driver.Close();
    }
}
