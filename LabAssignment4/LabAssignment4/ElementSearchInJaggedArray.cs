﻿using System;

namespace LabAssignment4
{
    class ElementSearchInJaggedArray
    {
        static void Main()
        {
            int[][] a = new int[][] { new int[] { 0, 0 }, new int[] { 1, 2 }, new int[] { 2, 4 }, new int[] { 3, 6 }, new int[] { 4, 8 } };
            int i, j;

            for(i=0;i<5;i++)
            {
                for ( j = 0; j < 2; j++)
                { 
                    Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]); 
                }

            }
          
                Console.WriteLine(a[2][1]); 
            Console.ReadLine();

        }
    }
}








