using System;


namespace lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            Student su = new Student();
            try
            {
                su.StudentID = "59030185";
                su.Salary = 315;
                Console.WriteLine("StudentID : " + su.StudentID);
                Console.WriteLine("Salary by day : " + su.Salary);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
    class Student
    {
        private string getStudentID;
        private double getSalary;

        public string StudentID
        {
            get { return getStudentID; }
            set { getStudentID = value; }
        }
        public double Salary
        {
            get { return getSalary; }
            set
            {
                if (value > 300 && value <= 450)
                    getSalary = value;
                else
                    throw (new Exception("Error!!!! invalid Salary"));

            }
        }
    }
}

