using System;

namespace DemoRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Patterns patterns = new Patterns();
            bool flag = true;
            while(flag)
            { 
                Console.WriteLine("Choose the program to be executed : \n 1. PinCode Validation \n 2. Email validation \n 3. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine(patterns.validatePinCode("400008"));
                        Console.WriteLine(patterns.validatePinCode("A400008"));
                        Console.WriteLine(patterns.validatePinCode("400008B"));
                        Console.WriteLine(patterns.validatePin("400 008"));
                        break;
                    case 2:
                        Console.WriteLine(patterns.validateFirstName("abc"));
                        Console.WriteLine(patterns.validateSecondPart("abc@bridgelabz"));
                        Console.WriteLine(patterns.validateThirdPart("abc@bridgelabz.co"));
                        Console.WriteLine(patterns.validateOptionalPart("abc.xyz@bridgelabz.co.in"));
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }           
        }
    }
}