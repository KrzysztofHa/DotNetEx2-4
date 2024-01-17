
using System;
using System.Text.RegularExpressions;


namespace DotNetEx

{
    class Program
    {
       

        private static void Main(string[] args)
        {
            //Lekcja 2/4 
            //zadanie 1  program deklarujący zmienne danych pracownika firmy
            
            string name;
            string sec_name;
            decimal age; //może ktoś podać na przykład 43,5
            char sex;
            ulong pesel;
            ulong nr_worker;

            Console.WriteLine("A program that declares variables in code");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();


            //zadanie 2 zadeklarować zmienne i wypisać je w odwrotnej kolejności niż zadeklarowano

            string first = "w";
            string sec = "z";
            string the = "x";

            Console.WriteLine("The program declares three variables in the code and displays them in reverse order");
            Console.WriteLine(the);
            Console.WriteLine(sec);
            Console.WriteLine(first);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // Zadanie 3 program do obliczania długości przeciwprostokątnej

            double[] a = new double[2] { 0, 0 };
            string t = "";
            bool calculate = false;
            
            Console.Clear();
            Console.WriteLine("Calculation of hypotenuse unit mm");
            Console.WriteLine("Enter the numbers 'a' and 'b' of the sides of the rectangle:");
            Console.WriteLine("positive and range from 1 - 20");

            for (int i = 0; i <= a.Length - 1; i++)
            {

                do
                {                 
                    if (a[a.Length - 2] == 0)
                    {
                        Console.WriteLine("Enter the number 'a'");
                        t = Console.ReadLine();
                    }
                    else if (a[a.Length - 1] == 0)
                    {
                        Console.WriteLine("Enter the number 'b'");
                        t = Console.ReadLine();
                    }
                    if (Double.TryParse(t, out a[i]) & (a[i] > 0) & (a[i] < 21))
                    {

                        Console.WriteLine("The number is correct \n");
                        a[i] = a[i];
                        if (a.Length - 1 == i)
                        {
                            calculate = true;
                        }
                        break;
                    }
                    else
                    {
                        a[i] = 0;
                        Console.Clear();
                        Console.WriteLine("You have not entered any number or the number is incorrect");
                        Console.WriteLine("Enter a valid positive number between 1-20");
                    }
                }
                while (true);
                {
                    if (calculate)
                    {
                        Console.Clear();
                        Console.WriteLine("number 'a': {0}mm number 'b': {1}mm \n", a[0], a[1]);
                        double j = (Math.Pow(a[0], 2) + Math.Pow(a[1], 2));
                        Console.WriteLine("length of the hypotenuse = {0}mm\n", j);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    }
                }

               
            }

            // Zadanie 4 stwórz dwie zmienne liczbowe i jedną tekstową i przypisz im wartości:
            // a. 10
            // b. Szkoła Dotneta
            // c. 12.5

            int aa;
            string bb;
            double cc;

            aa = 10;
            bb = "Szkoła Dotneta";
            cc = 12.5;
        
            // Zadanie 5 Napisz program w którym użytkownik poda jak najwięcej danych o sobie
            var data = new Data();
            data.DataRead();
             

        }
    }
}