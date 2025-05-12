using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationAndCSharpBasics.Selenium;

public class ManageCookies
{
    [Test]
    public void CookiesTest()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Manage().Cookies.DeleteAllCookies();
        driver.Navigate().GoToUrl("https://www.amazon.in/ap/signin?openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.in%2F%3Fref_%3Dnav_signin&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.assoc_handle=inflex&openid.mode=checkid_setup&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0");

        // Enter email
        IWebElement emailField = driver.FindElement(By.XPath("//input[@type='email']"));
        emailField.SendKeys("Akhtarsameer743@gmail.com");

        // Click Continue
        IWebElement continueButton = driver.FindElement(By.XPath("//input[@id='continue']"));
        continueButton.Click();

        // Enter Password
        IWebElement passwordField = driver.FindElement(By.XPath("//input[@type='password']"));
        passwordField.SendKeys("");

        // Click Sign In
        IWebElement signInButton = driver.FindElement(By.XPath("//input[@id='signInSubmit']"));
        signInButton.Click();
        // IList<Cookie> cookies = driver.Manage().Cookies.AllCookies;
        // foreach (Cookie cookie in cookies)
        // {
        //     Thread.Sleep(2000);
        //     driver.Manage().Cookies.DeleteCookie(cookie);
        //     TestContext.Out.WriteLine("Deleted cookie: " + cookie.Name);
        //     driver.Navigate().Refresh();
        // }
        driver.Manage().Cookies.DeleteCookieNamed("x-acbin"); //---Logs out after deleting this cookie
    }
}
