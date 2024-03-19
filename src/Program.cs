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
                return "Invalid Tempreture Unit! Please try again.";
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

                Console.WriteLine("-----------------Tempreture Converter----------------");

                Console.Write("Enter a temperature and its unit (C or F), or type 'Quit' to exit: ");
                string field = Console.ReadLine() ?? "";

                if (field.ToLower().Equals("quit"))
                {
                    Console.WriteLine("Program terminated.");
                    break;
                }

                string[] temperature = field.Split(" ");
                if (temperature.Length != 2)
                {
                    Console.WriteLine("Invalid Inputs. Please Enter Tempreture value and its unit (F or C), ex. '20 F'");
                    continue;
                }

                if (!double.TryParse(temperature[0], out double tempValue))
                {
                    Console.WriteLine("Invalid input. Please enter a numeric temperature.");
                    continue;
                }

                string tempUnit = temperature[1].ToUpper();
                if (!tempUnit.Equals("C") && !tempUnit.Equals("F"))
                {
                    Console.WriteLine("Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.");
                    continue;
                }

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