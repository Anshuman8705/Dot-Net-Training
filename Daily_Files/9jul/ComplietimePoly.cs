// suppose an API allows Searching in different ways 
// search method is same but parameteers will change 
// same method , diffeerent parameters 
// compiler decides which method to call based on the parameters passed to it

using System;
class CompiletimePoly
{
    public void Search(int id)
    {
        Console.WriteLine("Searching by Employee ID: ");
    }
    public void Search(string firstname, string lastname)
    {
        Console.WriteLine("Searching by Name ");
    }
    public void Search(long phone)
    {
        Console.WriteLine("Search by Phone ");
    }

}