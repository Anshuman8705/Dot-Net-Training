using System.Collections.Generic;
// list and dictionary,
class Collection{
    static void Main(){
        List<String> names = new List<string>();
        names.Add("Ammar");
        names.Add("Ali");
        names.Add("Ahmed");
        names.Add("Anshu");
        names.Add("Zaid");
        names.Add("Raj");
        names.Add("Imran");
        names.Add("Rahul");
        names.Add("Rohan");
        names.Add("Sahil");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        //////////
        /// 
        /// 
        List<Stud> st = new List<Stud>()
        {
            new Stud{id=1,name="Ammar"},
            new Stud{id=2,name="Ali"},
        };
        List<Teacher> te = new List<Teacher>()
        {
            new Teacher{tid=1,tname="Soham"},
            new Teacher{tid=2,tname="Amit"},
        };

        foreach (var stu in st)
        {
            Console.WriteLine(stu.name);
        }

        foreach (var teacher in te)
        {
            Console.WriteLine(teacher.tname);
        }

    }
}
