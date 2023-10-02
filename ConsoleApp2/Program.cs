using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string: ");
            string stg = Console.ReadLine(); ;

            // countADS(stg);

            //ascendingOrder(stg);

            //subtracting(stg); 

            //Console.WriteLine("After Convertion: "+ upperLowerConvert(stg));

            //isAlphOrNot(stg);

            isEndWithDot(stg); 
            Console.Read();
           
        }
        /* Write a program in C# Sharp to count the number of alphabets, digits and special characters in a string.
 Test Data :
 Input the string : Welcome to Showit1.com
 Expected Output :

 Number of Alphabets in the string is : 18
 Number of Digits in the string is : 1 
 Number of Special characters in the string is : 3*/

        public static void countADS(string a)
        { 

            int alphabetCount = 0;
            int digitCount = 0;
            int specialCharCount = 0;

            for (int i = 0; i < a.Length; i++)
            {
                char c = a[i];

                if (char.IsLetter(c))
                {
                    alphabetCount++;
                }
                else if (char.IsDigit(c))
                {
                    digitCount++;
                }
                else
                {
                    specialCharCount++;
                }
            }

            Console.WriteLine("Number of Alphabets in the string is: " + alphabetCount);
            Console.WriteLine("Number of Digits in the string is: " + digitCount);
            Console.WriteLine("Number of Special characters in the string is: " + specialCharCount);
        }

        /*Write a C# Sharp program to sort a string array in ascending order.
Test Data :
Input the string : this is a string
Expected Output :

After sorting the string appears like : 
a g h i i i n r s s s t t*/


       public static void ascendingOrder(string a)
        {
            char[] chars = a.ToCharArray();

            Array.Sort(chars);
            
           
            string charsstring = new string(chars);

            charsstring.Split();  

            Console.WriteLine(charsstring);
          

        }
        /*Write a program in C# Sharp to extract a substring from a given string without using the library function.
Test Data :
Input the string : This is a test string
Input the position to start extraction :5
Input the length of substring :5
Expected Output :

The substring retrieve from the string is :  is a*/

        public static void subtracting(string a)
        {

            int n; int e;
            Console.WriteLine("Input the starting position: ");
             n = Convert.ToInt32(Console.ReadLine());

            /*Console.WriteLine("Input the lenth of subtracting: ");
            e = Convert.ToInt32(Console.ReadLine());*/


            for (int i = n; i <= a.Length; i++)
            {
                
            }
        }

       /* Write a C# Sharp program to read a sentence and replace lowercase characters with uppercase and vice-versa.
Test Data :
Input the string : This is a string
Expected Output :

After conversion, the string is : tHIS IS A STRING*/

        static string upperLowerConvert(string a)
        {
            Char[] chars = a.ToCharArray();

            for (int i = 0;i < chars.Length; i++)
            {
                if (char.IsLower(chars[i]))
                {
                    chars[i] = char.ToUpper(chars[i]);
                }
                else if (char.IsUpper(chars[i]))
                {
                    chars[i] = char.ToLower(chars[i]);
                } 
                  
                                
            }
            return new string(chars);
        }

        /*Write a C# Sharp program to check whether a character is an alphabet and not and if so, check for the case.
    Test Data :
    Input a character: Z

    Expected Output :

    The character is uppercase.*/

        static void isAlphOrNot(string a)
        {
            char[] chars = a.ToCharArray();

            if (chars.Length == 0)
            {
                Console.WriteLine("Please Input the Alpha or Digit");
                

            }else if(chars.Length == 1)
            {
                if (char.IsDigit(a[0]))
                {
                    Console.WriteLine("It is Digit");
                }
                else if (char.IsLetter(a[0]))
                {
                    if (char.IsUpper((char)a[0]))
                    {
                        Console.WriteLine("The character is Uppercase");
                    }
                    else
                    {
                        Console.WriteLine("The character is LowerCase");
                    }
                }else
                {
                    Console.WriteLine("It is a Special Character");
                }
                     
                
            }
            else
            {
                Console.WriteLine("Invalid Input!! Please input only one character");
            } 
            
        }
        /*Write a C# Sharp program to indicate whether each string in an array ends with a period (".").

Expected Output :

'Actions speak louder than words' ends in a period: False                        
'Hello!' ends in a period: False                                                 
'Python.' ends in a period: True                                                 
'PHP.' ends in a period: True                                                    
'random' ends in a period: False*/

        static void isEndWithDot(string a)
        {
            char[] chars = a.ToCharArray();

            if(chars.Length == 0)
            {
                Console.WriteLine("Please Input the String...");
            }
            else if (char.Equals(a[chars.Length-1], '.')) {

                Console.WriteLine("True");
            }
            else
            {
                 Console.Write("False");
            }
        }

    }

}

