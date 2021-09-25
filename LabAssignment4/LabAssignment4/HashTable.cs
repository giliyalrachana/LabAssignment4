using System;
using System.Collections;


namespace LabAssignment4
{
    class HashTable
    {
        static void Main()
        {
            HashTable hashtable = new HashTable();

            hashtable.Add("India", "+91");
            hashtable.Add("USA", "+1");
            hashtable.Add("China", "+86");
            hashtable.Add("UK", "+44");
            hashtable.Add("Korea", "+82");
            hashtable.Add("UAE", "+971");
            Console.WriteLine($"Count is :{hashtable.Count}");

            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine($"Country is = {key} and Telephone code is = {hashtable[key]}");
            }
            Console.ReadLine();
        }
    }
}
