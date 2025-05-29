using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace AutomationAndCSharpBasics.Playwright;

public class ChildWindowTest : PageTest
{
    [Test]
    public async Task ChildWindow()
    {
        // IBrowserContext context = await Browser.NewContextAsync();
        var page = await Context.NewPageAsync();
        ILocator username = page.Locator("#username");
        ILocator password = page.Locator("#password");
        ILocator signIn = page.Locator("#signInBtn");
        await page.GotoAsync("https://rahulshettyacademy.com/loginpagePractise/");
        await page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        await Expect(page).ToHaveTitleAsync("LoginPage Practise | Rahul Shetty Academy");
        // Get page after a specific action (e.g. clicking a link)
        var newPage = await Context.RunAndWaitForPageAsync(async () =>
        {
            await page.Locator(".blinkingText").Nth(0).ClickAsync();
        });
        await TestContext.Out.WriteAsync(await newPage.TitleAsync());
        // await newPage.CloseAsync();
        await page.BringToFrontAsync();
        await username.FillAsync("rahulshettyacademy");
        await password.FillAsync("learning");
        await page.Locator("#terms").ClickAsync();
        await signIn.ClickAsync();
    }
}
// HEADED=1 dotnet test --filter "FullyQualifiedName~ChildWindowTest"