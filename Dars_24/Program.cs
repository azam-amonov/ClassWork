// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices.ComTypes;
using Dars_24.Practic;
using N22_T1.Models;

Console.WriteLine("Dasr -> 24");
// var student = new Student<Guid, string>(Guid.NewGuid(), "Qurbonjon", "Foundation");
// var student2 = new Student<Guid, string>(Guid.NewGuid(), "Alamjon", "Basic");
// var student3 = new Student<Guid, string>(Guid.NewGuid(),"G'aybulla", "Elementry");
//
// var course = new Course(Guid.NewGuid(), "dotNet");
// var course2 = new Course(Guid.NewGuid(), "English");
//
//  University<Student<Guid,string >, Guid, string> university = new University<Student<Guid,string>, Guid, string>();
//  university.EnrollStudent(student, course);
// university.EnrollStudent(student2, course);
// university.EnrollStudent(student3, course);
//  university.DisplayStudents();
var priorityQueue = new PriorityQueue<ITaskEvent>();

priorityQueue.Enqueue(new TaskItem("Course", "Finish udemy course", 8));
priorityQueue.Enqueue(new TaskItem("Homework", "Do homework", 1));
priorityQueue.Enqueue(new TaskItem("Toqqa", "G`ishtmatni ko'rishga", 5));
priorityQueue.Enqueue(new TaskItem("Turnir", "Join to Internal Pointer Cybpersport team", 6));

priorityQueue.Enqueue(new EventItem("Meeting with clients", DateTime.Now.AddHours(1)));
priorityQueue.Enqueue(new EventItem("Najot Quiz", DateTime.Now.AddHours(2)));
priorityQueue.Enqueue(new EventItem("Sharpist Hackathon", DateTime.Now.AddDays(2)));
priorityQueue.Enqueue(new EventItem("Exam", DateTime.Now.AddHours(5)));

foreach(var item in priorityQueue)
{
    Console.WriteLine(item);
}

Console.WriteLine();

var q = priorityQueue.Dequeue();
Console.WriteLine(q);

