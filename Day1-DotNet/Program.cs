class Program
{
    private static double memoryResult = 0;
    private static List<double> calculationHistory = new List<double>();
    private static List<double> conversionHistory = new List<double>();

    static void Main(string[] args)
    {

        Console.WriteLine("Calculator Console App - Basic Arithmetic Operations");

        Console.WriteLine("1. Calculator");
        Console.WriteLine("2. Unit Conversion");
        int choice = int.Parse(Console.ReadLine());

        if(choice == 1)
        {
            Console.WriteLine("Enter First Number");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Select An Operator :");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Calculation History");

            int opt = int.Parse(Console.ReadLine());

            CalculateData(num1, num2, opt);
        }
        else
        {
            Console.WriteLine("Welecome to Unit Converter");

            Console.WriteLine("Select a unit conversion:");
            Console.WriteLine("1. Inches to Centimeters");
            Console.WriteLine("2. Pounds to Kilograms");
            Console.WriteLine("3. Centimeters to Meters");
            Console.WriteLine("4. Meters to Kilometers");
            Console.WriteLine("5. Grams to Kilograms");

            int num = int.Parse(Console.ReadLine());
            if(num>0 && num < 6)
            {
                Console.WriteLine("Enter an input value to convert");
                double inputValue = double.Parse(Console.ReadLine());
                unitConverter(num, inputValue);

            }
            else
            {
                Console.WriteLine("Please enter a valid number");
                
            }
        }


        
    }


    static void unitConverter(int num, double inputValue)
    {

        double unitResult = 0;

        switch (num)
        {
            case 1:
                unitResult = inputValue* 2.54; // Inches to Centimeters
                break;

            case 2:
                unitResult = inputValue * 0.453592;  //Pounds to Kilograms
                break;

            case 3:
                unitResult = inputValue * 0.01;  // Centimeters to Meters
                break;

            case 4:
                unitResult = inputValue * 0.001;  //Meters to Kilometers
                break;

            case 5:
                unitResult = inputValue * 0.001; //Grams to Kilograms
                break;


            default:

                return;

        }

        Console.WriteLine("Result : " + unitResult);
        conversionHistory.Add(unitResult);
        Console.WriteLine("For viewing Conversion History Press 1 else 0");
        int pressKey = int.Parse(Console.ReadLine());
        if (pressKey == 1)
            ViewConversionHistory();
        else
            return;


    }


    static void CalculateData(double num1, double num2, int opt)
    {
        double calculatorResult = 0;

        try
        {

            switch (opt)
            {
                case 1:
                    calculatorResult = num1 + num2;
                    break;

                case 2:
                    calculatorResult = num1 - num2;
                    break;

                case 3:
                    calculatorResult = num1 * num2;
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        calculatorResult = num1 / num2;
                        break;
                    }
                    else
                    {
                        throw new DivideByZeroException();
                    }

                case 5:
                    ViewCalculationHistory();
                    return;

                default:
                    Console.WriteLine("Error !!! : Please select a valid operation");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");
                    int num = int.Parse(Console.ReadLine());
                    CalculateData(num1, num2, num);

                    return;
            }

            Console.Write("Please Enter the number of decimal places for the result ");
            int decimalPlaces = int.Parse(Console.ReadLine());

            string formattedResult = Math.Round(calculatorResult, decimalPlaces).ToString();
            Console.WriteLine("Result is : " + formattedResult);

            Console.WriteLine("1. Store Result in Memory");
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                StoreResultInMemory(double.Parse(formattedResult));

                Console.WriteLine("Press any key to Retrieve Result from Memory");
                int keyPressed = int.Parse(Console.ReadLine());
                RetrieveResultFromMemory();
            }
            else
            {
                throw new Exception();
            }

        }

        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input format.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }



    }

    static void StoreResultInMemory(double result)
    {
        memoryResult = result;
        calculationHistory.Add(memoryResult);
        Console.WriteLine($"Result {result} has been stored in memory.");
    }

    static double RetrieveResultFromMemory()
    {
        Console.WriteLine($"Retrieved result from memory: {memoryResult}");
        return memoryResult;
    }

    static void ViewCalculationHistory()
    {
        Console.WriteLine("Calculation History:");

        if (calculationHistory.Count == 0)
        {
            Console.WriteLine("No calculations in history.");
            return;
        }

        for (int i = 0; i < calculationHistory.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {calculationHistory[i]}");
        }
    }

    static void ViewConversionHistory()
    {
        Console.WriteLine("Conversion History:");

        if (conversionHistory.Count == 0)
        {
            Console.WriteLine("No Conversion in history.");
            return;
        }

        for (int i = 0; i < conversionHistory.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {conversionHistory[i]}");
        }
    }




}