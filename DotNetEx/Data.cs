using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static DotNetEx.CheckData;

namespace DotNetEx;

internal class Data
{
    public string  Name { get; }
    public string Secname { get; }
    public char Sex { get; }
    public ulong Tel { get; }
    public string Pesel { get; } //11 liczb
    public string Email { get; }
    
    public Data()
    {
        Console.WriteLine("Program for loading data from the user");

        Name = string.Empty;
        while (string.IsNullOrEmpty(Name))
        {
            Console.Clear();
            Console.WriteLine("Enter name");
            Name = Console.ReadLine();
        }

        Secname = string.Empty;
        while (string.IsNullOrEmpty(Secname))
        {

            Console.Clear();
            Console.WriteLine("Enter secend name ");
            Secname = Console.ReadLine();
        }
        
        ConsoleKeyInfo ex;
        do
        {
            Console.Clear();
            Console.WriteLine("Enter  sex \n woman pres key  'W' or men press key 'M'");
            ex = Console.ReadKey(true);
        } while(ex.Key != ConsoleKey.W & ex.Key != ConsoleKey.M);
        Sex = ex.KeyChar;

        string data = string.Empty;
        bool check = false;
        ulong d = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Enter your mobile phone number with 9 digits");
            data = Console.ReadLine();
            check = ulong.TryParse(data, out d);

            if (check)
            {
                if (data.Length == 9)
                {
                    Tel = d; break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Enter a valid positive number containing a maximum of 9 digits");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You have not entered any number or the number is incorrect");
                Console.WriteLine("Enter a valid positive number containing a maximum of 9 digits");                    
            }

        } while (true);      

        Console.Clear();        
        do
        {
            Console.WriteLine("\n Enter your email address");
            Console.WriteLine("\n letters, numbers, underscore (_ ), dot (.), dash (-) are allowed. \nThe identifier cannot begin with an underscore" +
                " (_ ), dot (.) or dash (-), e.g.: _kowlaski@firma. com.pl. \nthe identifier cannot contain spaces, e.g.: jan kowlaski@firma.com.pl.");
            data = Console.ReadLine();                
            if (IsValidEmail(data))
            {
                Email = data;
                break;
            }
        } while (true);            
    }
    
    public void DataRead()
    {
        Console.WriteLine("Profil\n name {0}\n secendname {1}\n sex {2}\n nember telephon {3}\n " +
            "email {4}\n ",
            Name, Secname, Sex, Tel, Email);
        Console.WriteLine("Press any key to EXIT");
        Console.ReadKey();
    }       
}