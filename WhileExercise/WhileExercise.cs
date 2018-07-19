using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileExercise
{
    class WhileExercise
    {
        static void Main(string [] args)
        {
            int x, sum;
            x = 1; sum = 0;
            sum += x;
            Console.WriteLine("The sum is: {0}", sum);
            Console.WriteLine("Begin While Loop demonstration: ");
            while (sum < 11)
            {
                Console.WriteLine(sum);
                    sum++; }//end while loop
            Console.WriteLine("The sum has exceeded 10.");
            Console.ReadKey();
        }
    }//end 
}//end namespace
