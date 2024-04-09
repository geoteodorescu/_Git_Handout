//
class Program
{
    static void Main()
    {
        Fn_ex4();
    }
    static int GetMin(int nr1, int nr2)
    {
        if (nr1 > nr2)
        {
            return nr2;
        }
        else if (nr1 < nr2)
        {
            return nr1;
        }
        else
        {
            return 0;
        }
    }
    static void Fn_ex4()
    {
        Console.WriteLine("Scrie primul numar:");
        var firstNumber = Console.ReadLine();
        Console.WriteLine("Scrie al doilea numar:");
        var secondNumber = Console.ReadLine();
        bool success1 = int.TryParse(firstNumber, out int result_1);
        bool success2 = int.TryParse(secondNumber, out int result_2);
        Console.WriteLine("Numarul cel mai mic este: " + GetMin(result_1, result_2));

        /*
        bool success1 = int.TryParse(firstNumber, out int result_1);
        Console.WriteLine("Scrie al doilea numar:");
        var secondNumber = Console.ReadLine();
        bool success2 = int.TryParse(secondNumber, out int result_2);
        if (success1 == true && success2 == true)
        {
            Console.WriteLine("Numarul cel mai mic este: " + GetMin(result_1, result_2));
        }
        else
        {
            Console.WriteLine("Ups.");
        }
        */
    }
}