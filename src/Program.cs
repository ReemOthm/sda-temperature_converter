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
        Console.WriteLine($"Tempreture 32 F converted:  {TempConvert(32, "F")}");
        Console.WriteLine($"Tempreture 100 C converted:  {TempConvert(100, "C")}\n");

        try
        {
            while (true)
            {

                Console.WriteLine("-----------------Tempretures Converted----------------");

                Console.Write("Enter a temperature and its unit (C or F), or type 'Quit' to exit: ");
                string field = Console.ReadLine() ?? "";

                if (field.ToLower().Equals("quit"))
                {
                    Console.WriteLine("Program terminated.");
                    break;
                }

                string[] temperature = field.Split(" ");
                double tempValue = Convert.ToDouble(temperature[0]);
                string tempUnit = temperature[1].ToUpper();

                string convertedTempreture = TempConvert(tempValue, tempUnit);

                Console.WriteLine($"Converted: {tempValue} {tempUnit} = {convertedTempreture}");

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}