using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace AutomationAndCSharpBasics.Playwright;

public class AlertTest : PageTest
{
    [Test]
    public async Task AlertDemoTest()
    {
        await Page.GotoAsync("https://rahulshettyacademy.com/AutomationPractice/");
        await Page.Locator("#name").FillAsync("Sameer");
        await Page.Locator("#alertbtn").ClickAsync();
        Page.Dialog += async (_, dialog) =>
        {
            await TestContext.Out.WriteAsync(dialog.Message);
            Console.WriteLine("Dialog appeared: " + dialog.Message);
            await dialog.AcceptAsync();
        };
    }
}
// HEADED=1 dotnet test --filter "FullyQualifiedName~AlertTest"