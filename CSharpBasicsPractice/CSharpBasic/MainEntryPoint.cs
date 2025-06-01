namespace CSharpBasicsPractice.CSharpBasic;

public class MainEntryPoint /*:InterfaceDemo /*: AbstractionDemo /*: ConstructorDemo*/
{
    /*  Constructor
    public MainEntryPoint(string name) : base(name)
    {
    }
    */

    public static void Main(string[] args)
    {
        // DictionaryDemo.DictionaryDemoTest();
        // HashingDemo.HashingTest();

        // MainEntryPoint mep = new MainEntryPoint("Sameer"); //---Constructor

        // MainEntryPoint mep = new MainEntryPoint(); //---For Abstract
        // mep.TruckDriver();
        // mep.CarDriver();

        // InterfaceDemo id = new MainEntryPoint(); //--Interface
        // id.Pilot();
        // id.Sailer();

        // ArrayDemo.ArrayDemoTest(); //--Normal Array
        // ArrayDemo.Array2Dimension(); //--2D Array
        // ListDemo.ListDemoTest(); //--List

        // Console.WriteLine(EnumDemo.LastLevel);

        // SwitchCaseDemo.SwitchCaseDemoTest(EnumDemo.Level2);

        // string email = "akhtarsameer743@gmail.com";
        // bool isValid = EmailValidation.IsValidEmail(email);
        // Console.WriteLine(isValid);

        Thread t = new Thread(ArrayDemo.Array2Dimension);
        Console.WriteLine(t.IsAlive); //--False
        t.Start();
        Console.WriteLine(t.IsAlive); //--True
        t.Join();
        Console.WriteLine(t.IsAlive); //--False

    }

    /*  Interface
    public void Pilot()
    {
        Console.WriteLine("Plane is being flown");
    }

    public void Sailer()
    {
        Console.WriteLine("Ship is being sailed");
    }
    */

    /*  Abstraction
    public override void TruckDriver()
    {
        Console.WriteLine("Truck is being driven");
    }
    public override void CarDriver()
    {
        base.CarDriver();
        Console.WriteLine("From Main");
    }
    */
}
