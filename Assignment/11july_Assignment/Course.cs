using System;

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public int Credits { get; set; }
    public Course(int courseId, string courseName, int credits)
    {
        CourseId = courseId;
        CourseName = courseName;
        Credits = credits;
    }
    public void Display()
    {
        Console.WriteLine("Course Id : " + CourseId);
        Console.WriteLine("Course Name : " + CourseName);
        Console.WriteLine("Credits : " + Credits);
    }
}