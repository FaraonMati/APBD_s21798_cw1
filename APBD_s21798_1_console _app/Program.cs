class Feature_average
{
    static void Main(string[] args)
    {
        Console.WriteLine("APBD_1");
        Console.WriteLine("s21798");
        Console.WriteLine("console app");

        var listOfIntegers = new List<int> { 12, 17, 25, 30, 6, 17, 156 };
        
        Console.WriteLine("feature_average= " + Average(listOfIntegers));
        Console.ReadLine();

    }
    public static double Average(List<int> numbers)
    {
        var sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }
        var avg = (float)sum / numbers.Count;
        return avg;
    }
}


