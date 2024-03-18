class Program
{
    public static string TempConvert(double tempValue, string tempUnit)
    {
        double result;
        switch (tempUnit)
        {
            case "C":
                result = (tempValue * 1.8) + 32;
                return $"{result} F";
            case "F":
                result = (tempValue - 32) / 1.8;
                return $"{result} C";
            default:
                return "Done";
        }
    }
    public static void Main()
    {
        Console.WriteLine(TempConvert(32, "F"));
        Console.WriteLine(TempConvert(100, "C"));
    }
}