using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace AutomationAndCSharpBasics.Playwright;

public class UniqueLocators : PageTest
{
    [Test]
    public async Task UniqueLocatorsTest()
    {
        await Page.GotoAsync("https://rahulshettyacademy.com/angularpractice/");
        await Page.PauseAsync();
        await Page.GetByLabel("Check me out if you Love IceCreams!").CheckAsync();
        await Page.GetByLabel("Employed").CheckAsync();
        await Page.GetByLabel("Gende").SelectOptionAsync("Female");
        await Page.GetByPlaceholder("Password").FillAsync("Sameerking");
        await Page.GetByRole(AriaRole.Button, new PageGetByRoleOptions { Name = "Submit" }).ClickAsync();
        await Page.GetByText("Success! The Form has been submitted successfully!.").WaitForAsync();
        await Page.GetByRole(AriaRole.Link, new() { Name = "Shop" }).ClickAsync();
        await Page.Locator("app-card").Filter(new() { HasText = "Nokia Edge" }).GetByRole(AriaRole.Button, new() { Name = "Add" }).ClickAsync();
    }
}
// HEADED=1 dotnet test --filter "FullyQualifiedName~UniqueLocators"