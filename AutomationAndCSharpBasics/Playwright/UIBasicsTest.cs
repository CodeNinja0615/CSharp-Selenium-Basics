using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace AutomationAndCSharpBasics.Playwright;

public class UIBasicsTest : PageTest
{
    [Test]
    public async Task BrowserTest()
    {
        IBrowserContext context = await Browser.NewContextAsync();
        IPage page = await context.NewPageAsync();
        await page.GotoAsync("https://google.com/");
    }

    [Test]
    public async Task PagePlaywrightTest()
    {
        ILocator username = Page.Locator("#username");
        ILocator password = Page.Locator("#password");
        ILocator signIn = Page.Locator("#signInBtn");
        await Page.GotoAsync("https://rahulshettyacademy.com/loginpagePractise/");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        await Expect(Page).ToHaveTitleAsync("LoginPage Practise | Rahul Shetty Academy");
        await username.FillAsync("rahulshettyacadem");
        await password.FillAsync("learning");
        await Page.Locator("#terms").ClickAsync();
        await signIn.ClickAsync();
        await Expect(Page.Locator(".alert-danger[style*='block']")).ToContainTextAsync("Incorrect");
        await Expect(Page.Locator("[href*='rahulshetty']")).ToHaveAttributeAsync("class", "blinkingText");
        // await Page.Locator("//input[@value='user']").ClickAsync();
        await username.FillAsync("rahulshettyacademy");
        await password.FillAsync("learning");
        await signIn.ClickAsync();
        await Expect(Page.Locator(".navbar-brand").Nth(0)).ToHaveTextAsync("ProtoCommerce");
        // await Page.WaitForSelectorAsync("");
        IReadOnlyList<String> cartTitles = await Page.Locator(".card-body a").AllTextContentsAsync();
        await TestContext.Out.WriteLineAsync(cartTitles[0]);
    }
}
