namespace dava9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.Id = 1;
            student.FirstName = "Nika";
            student.LastName = "Beridze";

            //ERROR gamova, radgan asaki 16-dan 100-mde unda iyos
            student.Age = 10;
            student.Age = 20;

            student.Email = "nika@gmail.com";
            student.Password = "Nika12345";
            student.Phone = 599123456;
            student.Faculty = "Computer Science";
            student.Course = 2;
            student.AverageScore = 85.5;

            student.ShowInfo();
        }
    }
}
