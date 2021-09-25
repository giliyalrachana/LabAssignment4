using System;


namespace LabAssignment4
{
    class SumOfArrays
    {
        static void Main()
        {
            int[] SingleDimArray = new int[5];
            int num = 0;
            Console.WriteLine("Enter the value:");
            for (int i = 0; i < 5; i++)
            {
                SingleDimArray[1] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                num = SingleDimArray[1] + num;
            }
            Console.WriteLine($"The sum of array elements is :{num}");
            Console.ReadLine();

        }
    }
}
