
/* purpose: . Create a program that will allow the user to enter up to 25 numbers into an array. Calculate and
display the mean average of the numbers.
input: numbers
Output: avg.
*/

namespace CalcAverageInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///declare vars

            const int PhysicalSize = 25;
            int[] numbers = new int[PhysicalSize];
            int logicalSize;
            double average;

            ///load the array
            logicalSize = LoadArray(numbers, PhysicalSize);

            //calculate the average
            average = CalculateAverage(numbers, logicalSize);
            ///display the average
            
            Console.WriteLine($"The average of the numbers is {average}");


            Console.ReadLine();

        
            
        }///end of main
        static int LoadArray(int[] numbers, int size)
        {
            
            int index = 0,
            number;
            char again;

            do
            {
                Console.Write("Enter a number:");
                number = int.Parse(Console.ReadLine());
                numbers[index] = number;
                index++;
                /// now you want to check if the array is full. If not, prompt to add another number to the array. 
                if (index == size)
                {
                    again = 'N';
                }
                else
                {
                    Console.WriteLine("Add another? Y/N");
                    again = char.Parse(Console.ReadLine().ToUpper().Substring(0, 1));
                }
            }while (again == 'Y');  //the best way is to use the get safe int method. give this a try


            return index;
        
        }//end of load array

        //processing the array
        static double CalculateAverage(int[] numbers, int size)
        {
            double average = 0;
            for (int index = 0; index < size; index++)
            {
                average += numbers[index];
            
            }
            return average / size;
        
        }//end of CalculateAverage



    }
}