using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Conditional Statements*/
            /*First problem*/
            /* int degree;
            Console.WriteLine("Enter the degree:");
            degree = Convert.ToInt32(Console.ReadLine());
            if (degree<=0)
            {
                Console.WriteLine("Freezing weather.");
            }
            else if(degree>0 && degree < 15)
            {
                Console.WriteLine("Cool weather.");
            }
            else
            {
                Console.WriteLine("Hot weather.");

            }
            */

            /* Second problem*/

            /*int age;
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            if(age>0 && age < 13)
            {
                Console.WriteLine("Child");
            }
            else if(age>=13 && age <= 19)
            {
                Console.WriteLine("Teenager");
            }
            else if(age>19)
            {
                Console.WriteLine("Adult");
            }
            else { Console.WriteLine("You were not born"); }*/
            

            /* Third problem*/

            /*int variant;
            int temperature;
            double result;
            Console.WriteLine("Enter 1 to convert  Fahrenheit to Celsius, 2 to convert Celsius to Fahrenheit");
            variant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the temperature");
            temperature= Convert.ToInt32(Console.ReadLine());
            if (variant == 1)
            {
                result = (temperature - 32) * 5 / 9;
                Console.WriteLine(result);

            }
            else if (variant == 2)
            {
                result = 1.8 * temperature + 32;
                Console.WriteLine(result);

            }*/
            /*Array Manipulations*/
            /* First problem*/

            /* int[] arr = { 1, -3, -4, 8, 15, 146 };
            int min = arr[0];
            int max = arr[0];
            for(int i=0; i < arr.Length; i++)
            {
                if (arr[i] > max )
                {
                    max = arr[i];
                }
                else if (arr[i] < min){
                    min = arr[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            */
            /* Second problem*/

            /*int[] arr = { 1, -3, -4, 8, 15, 146 };
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;

            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            */
            /* Third problem*/
            /*int[] arr = { 1, -3, -4, 8, 15, 146 };
            int max = arr[0];
            int secondmax = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    secondmax = max;
                    max = arr[i];
                }
                else if (arr[i] > secondmax && arr[i] != max)
                {
                    secondmax = arr[i];
                }
            }
            Console.WriteLine(secondmax);
        }*/
            /* Fourth problem*/

            /* int[] arr1= { 1, -3, -4, 8, 15, 146 };
            int[] arr2= { 1, -3, -4, 8, 15, 146 };
            int[] result = new int[arr1.Length];
            if(arr1.Length == arr2.Length)
            {
                for(int i = 0; i < arr1.Length; i++)
                {
                    result[i] = arr1[i] + arr2[i];
                }
            }
            else
            {
                Console.WriteLine("Can't do that");
            }
            foreach(int item in result)
            {
                Console.WriteLine(item);
            }*/
            

            

        }
    }
}
