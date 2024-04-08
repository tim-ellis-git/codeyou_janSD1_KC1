using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Plan to make a validator method to verify the inputs and recursively call the method until a good input received 
// if 'dog' is entered it would return "not a valid number try again" until an acceptable one entered for the 
// do for both inputs (maybe allow for more), then use these returns as the input parameters of main method 
// only calling the get input to validate and appropriate math method

namespace KnowledgeCheck1_Calculator
{
    public static class GetInputs
    {
        public static void PromptForTWoNumbers(ref int inputnum1,ref int inputnum2)
        {
            Console.WriteLine("Enter the first number:");
                var num1string = Console.ReadLine();
                
            while(!int.TryParse(num1string, out inputnum1))
            {
                Console.WriteLine("Input not valid, try again");
                num1string = Console.ReadLine();
            }
            Console.WriteLine("Enter the second number:");
            var num2string = Console.ReadLine();
            while (!int.TryParse(num2string, out inputnum2))
            {
                Console.WriteLine("Input not valid, try again");
                num2string = Console.ReadLine();
            }


        }
        
        /*public double validateInputOne() { 
            var inputOne = Console.ReadLine();
            if (double.TryParse(inputOne, out double numberOne)) {
                return numberOne;
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not a valid number, try again");
                Console.ReadLine(); 
            }
        }*/  
    }
}

