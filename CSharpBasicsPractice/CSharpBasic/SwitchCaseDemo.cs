namespace CSharpBasicsPractice.CSharpBasic;

public class SwitchCaseDemo
{
    public static void SwitchCaseDemoTest(EnumDemo level)
    {
        switch (level)
        {
            case EnumDemo.Level1:
                Console.WriteLine("Start of the game.");
                break;
            case EnumDemo.Level2:
                Console.WriteLine("It's Level2!");
                break;
            case EnumDemo.Level3:
                Console.WriteLine("Almost Done!");
                break;
            case EnumDemo.LastLevel:
                Console.WriteLine("It's the done reset to Level1!");
                break;
            default:
                Console.WriteLine("Just another regular day.");
                break;
        }
    }
}
