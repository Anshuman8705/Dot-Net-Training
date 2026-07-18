using System;
class OOP
{
    static void Main()
    {
        Employee e = new Employee();
        e.EmpName = "Anshuman";
        e.Salary = 1000;

        Console.WriteLine("Employee Name : " + e.EmpName);
        Console.WriteLine("Employee Salary : " + e.Salary);

        Console.WriteLine();
    
// encapsulation: data protection , validation , controlled access to data
CompiletimePoly c = new CompiletimePoly();

c.Search(123);
c.Search(9876543210);
c.Search("John", "Doe");

Console.WriteLine();

//polymorphism: ability of an object to take many forms
// compile time polymorphism: method overloading

RuntimePoly r = new RuntimePoly();

r.Checkout(new UpiPayment(), 500);
r.Checkout(new CreditPayment(), 55000);
r.Checkout(new NetBanking(), 25000);

    


// runtime polymorphism: runtimepoly never knows which payment method will be used at runtime. It will be decided at runtime based on the object passed to it.
// it simply calls the actual implementation of the method based on the object passed to it. It is not concerned about the implementation of the method. It is only concerned about the interface of the method.
FileStorage s = new Abstracteg();
s.Upload("CV.pdf");
s.validateFile();

//abstract : caller doesnt know how google uploads files , implementation is hidden from the caller. Caller only knows that it can upload files to google drive.

    }
}