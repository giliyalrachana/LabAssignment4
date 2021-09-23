using System;

namespace LabAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = { 5,6,7,8,9,10 };
           //  numsArray[0] = 11;
            Console.WriteLine($"numsArray[1]={numsArray[1]}");

            foreach (var num in numsArray)
            {
                Console.Write($"{num}\t");
            }
            Console.ReadLine();
        }
    }
}
