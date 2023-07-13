namespace c_sharp;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("შეიყვანეთ რიცხვი:");
            int number = int.Parse(Console.ReadLine());
            if (number > 1)
            {
                int i=2;
                Boolean IsPrime = true;
                while (i <= number / 2)
                {
                    if (number % i == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                    i++;
                }
                if (IsPrime == true)
                {
                    Console.WriteLine("თქვენი შერჩეული რიცხვი მარტივია");
                }
                else
                {
                    Console.WriteLine("თქვენი შერჩეული რიცხვი შედგენილია");
                }
            }
            else
            {
                throw new Exception();
            }
        }
        catch
        {
            Console.WriteLine("შეიყვანეთ ვალიდური ციფრი");
        }
    }
}
