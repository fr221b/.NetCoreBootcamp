internal class Program
{
    private static void Main(string[] args)
    {
        //Student firstStudent = new Student();
        //Console.WriteLine("Please enter the FirstName");
        //firstStudent.FirstName = Console.ReadLine();
        //Console.WriteLine("Please enter the LastName");
        //firstStudent.LastName = Console.ReadLine();
        //Console.WriteLine("Please enter the Age");
        //firstStudent.Age = System.Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Please enter the Address");
        //firstStudent.Address = Console.ReadLine();

        BaseStudent baseStudent = new BaseStudent();
        //baseStudent.AddStudent(firstStudent);
        //baseStudent.UpdateStudent(2,"Matt","Damon",38,"NewYorkCity");
        //baseStudent.RemoveStudent(firstStudent);
        baseStudent.GetAll();
        Console.ReadLine();
    }
}