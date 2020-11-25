using System;

namespace _05.MethodsOverloading
{
    class OverloadingMethods // is - > many methods with one and same name but with different parameters  passed ! 
    {

        static int Multiply(int a, int b) 
        {
            return a * b;
        }

        static int Multiply(string a , string b) 
        {
            return Multiply(int.Parse(a), int.Parse(b));
        }

        static int Multiply(int[] numbers) 
        {
            int result = 1;
            foreach (int num in numbers)
            {
                result = Multiply(result, num);
            }
            return result;
        }
        static int Multiply(string[] numbersAsStrings)
        {
            int[] numbers = new int[numbersAsStrings.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(numbersAsStrings[i]);
            }
            return Multiply(numbers);
            
            
            int result = 1;
            foreach  (string numStr in numbersAsStrings)
            {
     0.
                    +result = Multiply(result, int.Parse(numStr));
    `        }
            return result;
        
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply("4", "5"));
            Console.WriteLine(Multiply(5, 4));
            Console.WriteLine(Multiply(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(Multiply(new string[] { "1", 2.ToString(), "3", 4.ToString() }));
        } //overloading methods are used :when we work  with different input data types theese dif data 
          //types to be worked with  one and same  concept action ;
          //in this example action is multiplication // Main IDEA OF Overlaoding methods //


    }
}
