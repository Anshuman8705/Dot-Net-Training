// serialization - converts an object into a form (JSON) so it can be saved and shared

using System;

using System.Text.Json;

class SerializeEg
{
    static void Main()
    {
        Employee e = new Employee(112, "Anshu", 15000);

        string json = JsonSerializer.Serialize(e);

        Console.WriteLine(json);

        //deceralize

       Employee? e1 = JsonSerializer.Deserialize<Employee>(json);

        if (e1 != null)
        {
        Console.WriteLine(e1.EmpName);
        }
        else
        {
        Console.WriteLine("Deserialization failed.");
        }
    }

}