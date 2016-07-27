using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public virtual string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (char.IsLower(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                this.firstName = value;
            }
        }

        public virtual string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (char.IsLower(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }
                this.lastName = value;
            }
        }
    }

    public class Student : Human
    {
        private string facultyNumber;
        public Student(string firstName, string lastName,string facultyNumber) 
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if ((value.Length < 5 || value.Length > 10) || !value.All(char.IsLetterOrDigit))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        public override string FirstName
        {
            get { return base.FirstName; }
            set
            {
                if (value.Length < 4)
                {
                    throw  new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }
                base.FirstName = value;
            }
        }

        public override string LastName
        {
            get { return base.LastName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }
                base.LastName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("First Name: " + this.FirstName)
                .AppendLine("Last Name: " + this.LastName)
                .AppendLine("Faculty number: " + this.FacultyNumber);
            return sb.ToString();
        }
    }
    
    public class Worker : Human
    {
        //week salary, work hours per day
        private double weekSalary;
        private double workHoursPerDay;
        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public override string LastName
        {
            get { return base.LastName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }
                base.LastName = value;
            }
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workHoursPerDay = value;
            }
        }

        public double calculateMoneyeByHour()
        {
            return this.WeekSalary/(this.workHoursPerDay*5);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("First Name: " + this.FirstName)
                .AppendLine("Last Name: " + this.LastName)
                .AppendLine("Week Salary: " + this.WeekSalary.ToString("F"))
                .AppendLine("Hours per day: " + this.WorkHoursPerDay.ToString("F"))
                .AppendLine("Salary per hour: " + this.calculateMoneyeByHour().ToString("F"));
            return sb.ToString();
        }
    }
    public class Mankind
    {
        static void Main()
        {
            try
            {
                string[] studentInfo = Console.ReadLine().Split();
                Student student = new Student(studentInfo[0],studentInfo[1],studentInfo[2]);
                string[] workerInfo = Console.ReadLine().Split();
                Worker worker = new Worker(workerInfo[0],workerInfo[1],double.Parse(workerInfo[2]),double.Parse(workerInfo[3]));
                Console.WriteLine(student.ToString());
                Console.WriteLine(worker.ToString());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
