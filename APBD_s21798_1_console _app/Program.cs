// See https://aka.ms/new-console-template for more information
Console.WriteLine("APBD_1");
Console.WriteLine("s21798");
Console.WriteLine("console app");

class feature_average
{
    static void Main()
    {
        var arrOfIntegers = new int[] { 12, 17, 25, 30, 6, 17, 156 };
        var sum = 0;
        for (int i = 0; i < arrOfIntegers.Length; i++)
        {
            sum += arrOfIntegers[i];
        }
        var avg = (float)sum / arrOfIntegers.Length;
        Console.WriteLine("feature_average= " + avg);


    }
}


