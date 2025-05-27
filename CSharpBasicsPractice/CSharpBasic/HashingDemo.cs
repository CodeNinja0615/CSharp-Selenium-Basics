namespace CSharpBasicsPractice.CSharpBasic;

public class HashingDemo
{
    public static void HashingTest()
    {
        ISet<string> hs = new HashSet<string>();
        hs.Add("Sameer");
        hs.Add("Akhtar");
        hs.Add("King");
        foreach (var item in hs)
        {
            Console.WriteLine(item);
        }
    }
}
