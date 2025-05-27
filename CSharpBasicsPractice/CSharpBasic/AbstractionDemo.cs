namespace CSharpBasicsPractice.CSharpBasic;

public abstract class AbstractionDemo
{
    public abstract void TruckDriver();

    public virtual void CarDriver()
    {
        Console.WriteLine("Car is being driven");
    }
}
