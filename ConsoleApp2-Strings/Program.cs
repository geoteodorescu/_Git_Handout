using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

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

        //search in strings
        int index1 = fullname3.IndexOf("Geo"); //0
        index1 = fullname3.IndexOf("Teo"); //7
        index1 = fullname3.IndexOf("GEO"); //-1 due to case sensitive
        index1 = fullname3.IndexOf("e", 1);
        Console.WriteLine(index1);

        //extract strings
        // C:/Holiday/2025/1/nice_pic.png
        string path = "C:/Holiday/2025/1/nice_pic.png";
        int index2 = path.IndexOf("."); // ia prima data cand gaseste caracterul
        index2 = path.LastIndexOf("."); // ia ultimul caracter care apare
        string file_extension = path.Substring(index2 + 1);
        int index3 = path.LastIndexOf("/");
        int index4 = index2 - index3 - 1;
        Console.WriteLine(index1);
        Console.WriteLine(index2);
        Console.WriteLine(index3);
        Console.WriteLine(index4);
        Console.WriteLine(path);
        string file_name = path.Substring(index3 + 1, index4);
        Console.WriteLine(file_name);
        Console.WriteLine(file_extension);

        //comparare stringuri
        #region Comparare stringuri
        string string1 = "oradea";
        string string2 = "Oradea";

        int result = String.Compare(string1, string2, true);
        if (result == 0)
        {
            Console.WriteLine("Stringurile sunt egale. (1)");
        }

        if (string1 == string2)
        {
            Console.WriteLine("Stringurile sunt egale. (2)");
        }

        if (string1.Equals(string2))
        {
            Console.WriteLine("Stringurile sunt egale. (3)");
        }

        if (string1.ToUpper().Equals(string2.ToUpper()))
        {
            Console.WriteLine("Stringurile sunt egale. (4)");
        }
        #endregion

        //splitting
        string listOfCities = "Londra, Paris, Iasi, Cluj, Bucuresti";
        string[] cities = listOfCities.Split(',', ' ', '.');
        foreach(string city in cities)
        {
            if (!string.IsNullOrWhiteSpace(city))
            {
                Console.WriteLine(city.ToUpper());
            }
        }

        //trim
        string myString1 = "          this is string       ";
        Console.WriteLine(myString1.TrimStart()); //la inceput, by default doar spatiu
        Console.WriteLine(myString1.TrimEnd()); //la final, by default doar spatiu
        Console.WriteLine(myString1.Trim()); //si inceput si final, by default doar spatiu

        string myString2 = "--------this is string---------- +++++";
        Console.WriteLine(myString2.Trim('-','+').Replace("-","")); //excludere caractere suplimentare fata de spatiu

        /*
        var stopWatch = new Stopwatch();
        string myCoolString = "Counting bottle: ";
        stopWatch.Start();
        for (int i = 0; i < 10000; i++)
        {
            myCoolString += i + " beers";
            //Console.WriteLine(myCoolString);
        }
        stopWatch.Stop();
        Console.WriteLine("Test 1: " + myCoolString);
        Console.WriteLine(stopWatch.Elapsed.TotalSeconds.ToString());

        Console.WriteLine(">>>>");
        //string builder - recomandat cand avem nevoie sa construim un string in cadrul unui for loop / while
        StringBuilder stringBuilder1 = new StringBuilder();

        var stopWatch2 = new Stopwatch();
        string myCoolString2 = "Counting bottle: ";
        stringBuilder1.Append(myCoolString2);

        stopWatch2.Start();
        for (int i = 0; i < 10000; i++)
        {
            stringBuilder1.Append(i.ToString() + " beers");
            //myCoolString2 += i + " beers";
        }
        stopWatch2.Stop();
        //Console.WriteLine("Test 2: " + stringBuilder1.ToString());
        //Console.WriteLine(stopWatch2.Elapsed.TotalSeconds.ToString());
        */
        // formatare stringuri: String.FOrmat()
        double d = 0.375;
        string infoToDisplay = d.ToString("P2");
        string infoToDisplay2 = String.Format("{0:F5}", d);
        string infoToDisplay3 = String.Format("{0,10:F5}", d);
        Console.WriteLine(infoToDisplay);
        Console.WriteLine(infoToDisplay2);
        Console.WriteLine(infoToDisplay3);
        // fromatare data
        DateTime dt1 = DateTime.Now;
        Console.WriteLine(dt1);
        var myFormatdt1 = String.Format("{0:d.MM.yyyy HH:mm}", dt1);
        Console.WriteLine(myFormatdt1);
        //culture
        CultureInfo culture = new CultureInfo("ro-RO");
        Console.WriteLine(dt1.ToString("d", culture));
        string myDate2 = "01.05.2024";
        var tommorow = dt1.AddDays(1);
        Console.WriteLine(tommorow.ToString());
        DateTime myDateFormat2 = DateTime.ParseExact(myDate2, "dd.MM.yyyy", CultureInfo.InvariantCulture); //se poate completa cultura dac ao stim, iar daca nu se foloseste invariant culture, un fel de ignore case sensitive
        Console.WriteLine(myDate2);
        Console.WriteLine(myDateFormat2.AddDays(-1).ToString());

        // string interpolation
        string student = "John";
        string age = "25";
        string str = $"Student {student} is {age} years old.";
        string str2 = "Student John is \"the best\".";          //escaping character
        string str3 = @"John is ""the best """;                 //verbatim (daca ai nevoie sa faci mai multe formatari ale textului, ca de exemplu sa punem textul pe mai multe randuri
        string str4 = "this is my super long " + 
            "string";
        string str5 = @"this is 
            my super long 
            string";

        Console.WriteLine("enter text using quotes");
        string quote = Console.ReadLine();
        Console.WriteLine(quote);

    }
}