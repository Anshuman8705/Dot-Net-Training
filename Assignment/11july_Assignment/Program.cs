using System;
using System.Collections.Generic;

class Program
{
    static List<Student> students = new List<Student>();
    static List<Course> courses = new List<Course>();
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== Student Management System =====");
            Console.WriteLine("1. Register Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Search Student by Id");
            Console.WriteLine("4. Add Course");
            Console.WriteLine("5. View All Courses");
            Console.WriteLine("6. Enroll Student in Course");
            Console.WriteLine("7. Display Student Details (info + courses + credits + fee)");
            Console.WriteLine("8. Exit");
            Console.Write("Enter Choice : ");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        RegisterStudent();
                        break;

                    case 2:
                        ViewAllStudents();
                        break;

                    case 3:
                        SearchStudent();
                        break;

                    case 4:
                        AddCourse();
                        break;

                    case 5:
                        ViewAllCourses();
                        break;

                    case 6:
                        EnrollStudent();
                        break;

                    case 7:
                        DisplayStudentDetails();
                        break;

                    case 8:
                        Console.WriteLine("Thank You...");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter Numbers Only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    static void RegisterStudent()
    {
        Console.Write("Enter Student Id : ");
        int id = Convert.ToInt32(Console.ReadLine());
        foreach (Student s in students)
        {
            if (s.Id == id)
            {
                Console.WriteLine("Student Id Already Exists.");
                return;
            }
        }
        Console.Write("Enter Student Name : ");
        string name = Console.ReadLine().ProperCase();
        Console.Write("Enter Department : ");
        string dept = Console.ReadLine();
        Console.WriteLine("Select Student Type : ");
        Console.WriteLine("1. Regular");
        Console.WriteLine("2. Scholarship");
        Console.WriteLine("3. Part-Time");
        Console.Write("Enter Choice : ");
        int typeChoice = Convert.ToInt32(Console.ReadLine());
        Student student;
        switch (typeChoice)
        {
            case 1:
                student = new RegularStudent(id, name, dept);
                break;
            case 2:
                student = new ScholarshipStudent(id, name, dept);
                break;
            case 3:
                student = new PartTimeStudent(id, name, dept);
                break;
            default:
                Console.WriteLine("Invalid type, defaulting to Regular.");
                student = new RegularStudent(id, name, dept);
                break;
        }
        students.Add(student);
        Console.WriteLine("Student Registered Successfully.");
    }
    static void ViewAllStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No Students Found.");
            return;
        }
        foreach (Student s in students)
        {
            s.Display();
        }
    }
    static void SearchStudent()
    {
        Console.Write("Enter Student Id : ");
        int id = Convert.ToInt32(Console.ReadLine());
        foreach (Student s in students)
        {
            if (s.Id == id)
            {
                s.Display();
                return;
            }
        }
        Console.WriteLine("Student Not Found.");
    }
    static void AddCourse()
    {
        Console.Write("Enter Course Id : ");
        int id = Convert.ToInt32(Console.ReadLine());
        foreach (Course c in courses)
        {
            if (c.CourseId == id)
            {
                Console.WriteLine("Course Id Already Exists.");
                return;
            }
        }
        Console.Write("Enter Course Name : ");
        string name = Console.ReadLine();
        Console.Write("Enter Credits : ");
        int credits = Convert.ToInt32(Console.ReadLine());
        courses.Add(new Course(id, name, credits));
        Console.WriteLine("Course Added Successfully.");
    }
    static void ViewAllCourses()
    {
        if (courses.Count == 0)
        {
            Console.WriteLine("No Courses Found.");
            return;
        }

        foreach (Course c in courses)
        {
            c.Display();
            Console.WriteLine("---------------------------");
        }
    }
    static void EnrollStudent()
    {
        Console.Write("Enter Student Id : ");
        int sid = Convert.ToInt32(Console.ReadLine());
        Student student = null;
        foreach (Student s in students)
        {
            if (s.Id == sid)
            {
                student = s;
                break;
            }
        }
        if (student == null)
        {
            Console.WriteLine("Student Not Found.");
            return;
        }
        Console.Write("Enter Course Id : ");
        int cid = Convert.ToInt32(Console.ReadLine());
        Course course = null;
        foreach (Course c in courses)
        {
            if (c.CourseId == cid)
            {
                course = c;
                break;
            }
        }
        if (course == null)
        {
            Console.WriteLine("Course Not Found.");
            return;
        }
        student.EnrollCourse(course);
    }
    static void DisplayStudentDetails()
    {
        Console.Write("Enter Student Id : ");
        int id = Convert.ToInt32(Console.ReadLine());
        foreach (Student s in students)
        {
            if (s.Id == id)
            {
                s.Display();
                return;
            }
        }
        Console.WriteLine("Student Not Found.");
    }
}