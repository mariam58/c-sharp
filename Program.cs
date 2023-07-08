namespace c_sharp;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter your first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num1);

        Console.WriteLine("Please, enter your second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num2);

        Console.WriteLine("Please, enter your math operator");
        string mathOperator = Console.ReadLine();

        string result;

        switch (mathOperator)
        {
            case "+":
                result = Convert.ToString(num1) + mathOperator + Convert.ToString(num2) + "=" + Convert.ToString(num1 + num2);
                break;

            case "-":
                result = Convert.ToString(num1) + mathOperator + Convert.ToString(num2) + "=" + Convert.ToString(num1 - num2);
                break;

            case "*":
                result = Convert.ToString(num1) + mathOperator + Convert.ToString(num2) + "=" + Convert.ToString(num1 * num2);
                break;

            case "/":
                result = Convert.ToString(num1) + mathOperator + Convert.ToString(num2) + "=" + Convert.ToString(num1 / num2);
                break;

            case "%":
                result = Convert.ToString(num1) + mathOperator + Convert.ToString(num2) + "=" + Convert.ToString(num1 % num2);
                break;

            default:
                result = "Your operatin is failed";
                break;
        }

        Console.WriteLine(result);
    }
}
