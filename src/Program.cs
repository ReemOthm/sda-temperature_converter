class Program
{
    public static string TempConvert(double tempValue, string tempUnit)
    {
        double result;
        switch (tempUnit)
        {
            case "C":
                result = (tempValue * 1.8) + 32;
                return $"{result:F2} F";
            case "F":
                result = (tempValue - 32) / 1.8;
                return $"{result:F2} C";
            default:
                return "Done";
        }
    }
    public static void Main()
    {

        Console.WriteLine(TempConvert(32, "F"));
        Console.WriteLine(TempConvert(100, "C"));

        Console.WriteLine("--------------Tempretures Converted-------------");

        Console.Write("Enter a temperature and its unit (C or F): ");
        string temperature = Console.ReadLine() ?? "";

        string[] temperatureArray = temperature.Split(" ");
        double tempValue = Convert.ToDouble(temperatureArray[0]);
        string tempUnit = temperatureArray[1].ToUpper();

        string convertedTempreture = TempConvert(tempValue, tempUnit);

        Console.WriteLine($"Converted: {tempValue} {tempUnit} = {convertedTempreture}");

    }
}