namespace AutomationAndCSharpBasics.NUnit;

[TestFixture]
[Parallelizable(ParallelScope.All)] //---Parallel execution of all method in a class & use .Self to run this class in parallel with mutliple class
public class Example01
{
    [Test, Category("Regression")]
    public void Test01()
    {
        TestContext.Out.WriteLine("Test 01 Completed");
    }

    [Test, Category("Smoke")]
    public void Test02()
    {
        TestContext.Out.WriteLine("Test 02 Completed");
    }

    [Test, Category("Regression")]
    [Parallelizable(ParallelScope.All)] //---All data sets parallel execution
    [TestCase("Sameer", "Engineer", "HCLTech")]
    [TestCase("Lionel", "Job Less", "No Where")]
    [TestCase("Kohli", "Chokli", "King Chokli")]
    public void Test03(String Name, String Job, String Place)
    {
        TestContext.Out.WriteLine($"Name: {Name}, Job: {Job}, Place: {Place}");
    }

    [Test, TestCaseSource(nameof(AddTestDataConfig)), Category("Smoke")]
    [Parallelizable(ParallelScope.All)] //---All data sets parallel execution
    public void Test04(String Name, String Job, String Place)
    {
        TestContext.Out.WriteLine($"Name: {Name}, Job: {Job}, Place: {Place}");
    }
    public static IEnumerable<TestCaseData> AddTestDataConfig()
    {
        yield return new TestCaseData("Sameer", "Engineer", "HCLTech");
        yield return new TestCaseData("Lionel", "Job Less", "No Where");
        yield return new TestCaseData("Kohli", "Chokli", "King Chokli");
    }
}


// dotnet test --filter "Category=Regression"
// dotnet test AutomationAndCSharpBasics.csproj --filter TestCategory=Regression
// dotnet test CSharpSeleniumFramework.csproj --filter TestCategory=Regression --% -- TestRunParameters.Parameter(name=\"browserName\",value=\"Edge\")