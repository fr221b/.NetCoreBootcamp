using System.Linq;
using Microsoft.EntityFrameworkCore;

public class BaseStudent : IStudent
{
    public void AddStudent(Student student)
    {
        using(var db = new Context())
        {
             db.Students.Add(student);
             db.SaveChanges();
        }
        
    }

    public List<Student> GetAll()
    {
        using(var db = new Context())
        {
            return db.Students.ToList();
        }
        
    }

    public Student GetStudentById(int studentId)
    {
        using(var db = new Context())
        {
               return db.Students.Find(studentId);
        }
                          
    }

    public void RemoveStudent(Student student)
    {
        using(var db = new Context())
        {
              db.Students.Remove(student);
              db.SaveChanges();
        }
    }

    public void UpdateStudent(int studentId,string firstName,string lastName,int age,string address)
    {
        using(var db = new Context())
        {
            Student newStu= db.Students.Find(studentId);
            newStu.FirstName = firstName;
            newStu.LastName = lastName;
            newStu.Age = age;
            newStu.Address = address;
            db.SaveChanges();
        }
    }
}