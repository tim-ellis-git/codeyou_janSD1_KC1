

/*
 * 
// Plan to make a validator method to verify the inputs and recursively call the method until a good input received 
// if 'dog' is entered it would return "not a valid number try again" until an acceptable one entered for the 
// do for both inputs (maybe allow for more), then use these returns as the input parameters of main method 
// only calling the get input to validate and appropriate math method
// then use the numbers from this method to replace the repeating console readline numbers in the main program

namespace KnowledgeCheck1_Calculator
{
    internal class GetNumbers
    {
        public double validateInputOne() { 
            var inputOne = Console.ReadLine();
            if (double.TryParse(inputOne, out double numberOne)) {
                return numberOne;
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not a valid number, try again");
                Console.ReadLine(); 
            }
        }  
    }
}

*/