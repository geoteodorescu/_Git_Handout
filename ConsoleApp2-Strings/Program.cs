using Microsoft.VisualBasic;

public static class Program
{
    public static void Main()
    {
        //declare strings
        string myFirstString = "Hello world!";
        Console.WriteLine(myFirstString);

        int myNumber = 44;
        string myNumberAsString = myNumber.ToString();

        //manipulate strings
        //concatenation
        string nume = "Teodorescu";
        string prenume = "George";
        string fullname1 = nume + " " + prenume;                //clasic, cu operatorul +
        string fullname2 = String.Concat(nume, " ", prenume);   //concatenare pe functie de strings
        string fullname3 = $"{nume} {prenume}";                 //interpolare
        Console.WriteLine(fullname1);
        Console.WriteLine(fullname2);
        Console.WriteLine(fullname3);

    }
}