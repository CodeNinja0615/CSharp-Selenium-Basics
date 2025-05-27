using System.Collections;

namespace CSharpBasicsPractice.CSharpBasic;

public class ListDemo
{
    public static void ListDemoTest()
    {
        IList<string> list = new List<string>();
        list.Add("Sameer");
        list.Insert(1, "Akhtar");
        list.Add("King");
        list[2] = "Garou";
        foreach (string str in list)
        {
            Console.WriteLine(str);
        }
    }
}
