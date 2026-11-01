using System.Text.RegularExpressions;


namespace dava9
{
    internal class Student
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _id = value;
                }
            }
        }



        private string _firstName = "";

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value.Length < 2)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _firstName = value;
                }
            }
        }



        private string _lastName = "";

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value.Length < 2)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _lastName = value;
                }
            }
        }



        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 16 || value > 100)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _age = value;
                }
            }
        }



        private string _email = "";

        public string Email
        {
            get { return _email; }
            set
            {
                if (!value.Contains("@") || !value.Contains("."))
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _email = value;
                }
            }
        }



        private string _password = "";

        public string Password
        {
            get { return _password; }
            set
            {
                if (value.Length < 8 || !Regex.IsMatch(value, @"[A-Z]") || !Regex.IsMatch(value, @"[a-z]") || !Regex.IsMatch(value, @"[0-9]"))
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _password = value;
                }
            }
        }



        private int _phone;

        public int Phone
        {
            get { return _phone; }
            set
            {
                if (value < 100000000 || value > 999999999)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _phone = value;
                }
            }
        }



        private string _faculty = "";

        public string Faculty
        {
            get { return _faculty; }
            set
            {
                if (value.Length < 2)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _faculty = value;
                }
            }
        }



        private int _course;

        public int Course
        {
            get { return _course; }
            set
            {
                if (value < 1 || value > 6)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _course = value;
                }
            }
        }



        private double _averageScore;

        public double AverageScore
        {
            get { return _averageScore; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _averageScore = value;
                }
            }
        }



        //yvela informaciis gamotana
        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"First name: {FirstName}");
            Console.WriteLine($"Last name: {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Password: {Password}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"Faculty: {Faculty}");
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"Average score: {AverageScore}");
        }
    }
}