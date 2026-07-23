using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Student
{
    // per-credit base rate used by the fee formulas in the derived classes
    public const double RatePerCredit = 1000;

    // every student can enrol in at most this many courses
    public const int MaxCourses = 6;

    public int Id { get; set; }
    public string StudentName { get; set; }
    public string Department { get; set; }

    public List<Course> EnrolledCourses { get; set; }

    public Student(int id, string name, string department)
    {
        Id = id;
        StudentName = name;
        Department = department;
        EnrolledCourses = new List<Course>();
    }

    // every student type calculates fee differently, so this is abstract
    public abstract double CalculateFee();

    public abstract string StudentType();

    public bool EnrollCourse(Course course)
    {
        if (EnrolledCourses.Any(c => c.CourseId == course.CourseId))
        {
            Console.WriteLine("Already enrolled in this course. Duplicate registration not allowed.");
            return false;
        }

        if (EnrolledCourses.Count >= MaxCourses)
        {
            Console.WriteLine("Enrollment limit reached. Cannot enroll in more than " + MaxCourses + " courses.");
            return false;
        }

        EnrolledCourses.Add(course);
        Console.WriteLine("Enrolled in " + course.CourseName + " successfully.");
        return true;
    }

    public int TotalCredits()
    {
        return EnrolledCourses.Sum(c => c.Credits);
    }

    public void Display()
    {
        Console.WriteLine("---------------------------");
        Console.WriteLine("Id : " + Id);
        Console.WriteLine("Name : " + StudentName);
        Console.WriteLine("Department : " + Department);
        Console.WriteLine("Student Type : " + StudentType());

        Console.WriteLine("Enrolled Courses : ");
        if (EnrolledCourses.Count == 0)
        {
            Console.WriteLine("  None");
        }
        else
        {
            foreach (Course c in EnrolledCourses)
            {
                Console.WriteLine("  " + c.CourseId + " - " + c.CourseName + " (" + c.Credits + " credits)");
            }
        }

        Console.WriteLine("Total Credits : " + TotalCredits());
        Console.WriteLine("Total Fee : " + CalculateFee());
        Console.WriteLine("---------------------------");
    }
}