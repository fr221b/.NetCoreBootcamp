public interface IStudent
{
        void AddStudent(Student student);
        void RemoveStudent(Student student);
        void UpdateStudent(int studentId,string firstName,string lastName,int age,string address);
        List<Student> GetAll();
        Student GetStudentById(int StudentId);
}