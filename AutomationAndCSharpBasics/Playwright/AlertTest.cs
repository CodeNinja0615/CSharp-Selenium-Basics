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

        var tcs = new TaskCompletionSource<string>();
        Page.Dialog += async (_, dialog) =>
        {
            await TestContext.Out.WriteLineAsync(dialog.Message);
            Console.WriteLine("Dialog appeared: " + dialog.Message);
            await dialog.AcceptAsync();
            tcs.SetResult(dialog.Message);
        };

        await Page.Locator("#alertbtn").ClickAsync();
        var dialogMessage = await tcs.Task;
        Assert.That(dialogMessage, Is.EqualTo("Hello Sameer, share this practice page and share your knowledge"));
    }
}
// HEADED=1 dotnet test --filter "FullyQualifiedName~AlertTest"