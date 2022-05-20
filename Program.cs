using System;
using System.Threading;


namespace ThisInCSHARP
{
    class Student
    {
        private DateOnly birthday = new DateOnly();
        private string firstName;
        private string surName;
        private string lastName;

        public Student (DateOnly birthday, string firstName, string surName, string lastName)
        {
            this.birthday = birthday;
            this.firstName = firstName;
            this.surName = surName;
            this.lastName = lastName;
        }

        public void Print ()
        {
            Console.WriteLine($"Студент: \n" +
                $"\tИмя: {firstName} \n" +
                $"\tФамилия: {surName}\n" +
                $"\tОтчество: {lastName}\n" +
                $"\tДата рождения: {birthday}");
        } 
    }



    class Program
    {

        static void Main(string[] args)
        { 
            Student student = new Student(new DateOnly(2022,05,20), "Абобус", "Дыбенко", "Михайлович");

            student.Print();
        }
    }
}