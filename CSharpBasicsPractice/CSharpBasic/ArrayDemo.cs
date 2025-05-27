namespace CSharpBasicsPractice.CSharpBasic;

public class ArrayDemo
{
    public static void ArrayDemoTest()
    {
        string[] arr = { "Sameer", "Akhtar", "King", "Garou" };

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    public static void Array2Dimension()
    {
        string[,] arr2D = new string[2, 3];
        arr2D[0, 0] = "Sameer";
        arr2D[0, 1] = "Akhtar";
        arr2D[0, 2] = "King";
        arr2D[1, 0] = "Garou";
        arr2D[1, 1] = "Apple";
        arr2D[1, 2] = "Banana";

        for (int i = 0; i < arr2D.GetLength(0); i++)
        {
            for (int j = 0; j < arr2D.GetLength(1); j++)
            {
                Console.WriteLine(arr2D[i, j]);
            }
        }
    }
}
