namespace CSharpBasicsPractice.CSharpBasic;

public class DictionaryDemo
{
    public static void DictionaryDemoTest()
    {
        IDictionary<string, int> map = new Dictionary<string, int>();
        map.Add("Sameer", 1);
        map["Akhtar"] = 2;
        map.Add("King", 3);
        map["King"] += 1;
        Console.WriteLine($"{map["King"]}");
        foreach (KeyValuePair<string, int> pair in map)
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }
    }
}
