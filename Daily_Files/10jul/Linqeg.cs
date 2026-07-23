// Linq = language Integrated Query 
// use to query collection like array, List 
// where() : filter data ,select(), orderBy(), orderByDescending()
// first(), count(), min(), max(), sum() 
using System;
using System.Linq;

class Linqeg
{
    static void main()
    {
        int[] numberss ={8,7,5,6,2,9,3};
        var even = numberss.Where(x=>x%2==0);

        foreach(var n in even)
        {
            Console.WriteLine(n);
        }
    }
}