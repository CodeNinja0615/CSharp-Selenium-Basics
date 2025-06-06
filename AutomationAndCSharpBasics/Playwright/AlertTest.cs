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
        Page.Dialog += async (_, dialog) =>
        {
            await TestContext.Out.WriteAsync(dialog.Message);
            Console.WriteLine("Dialog appeared: " + dialog.Message);
            Assert.That(dialog.Message, Is.EqualTo("Hello Sameer, share this practice page and share your knowledge"));
            await dialog.AcceptAsync();
        };
        await Page.Locator("#alertbtn").ClickAsync(); //---Always after promise event
    }
}
// HEADED=1 dotnet test --filter "FullyQualifiedName~AlertTest"