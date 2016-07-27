using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsByGroup
{
    class StudentsByGroup
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            List<string[]> a = new List<string[]>();
            List<Students> studens = new List<Students>();
            while (input[0] != "END")
            {
                a.Add(input);
                var someStudent = new Students
                {
                    FirstName = input[0],
                    LastName = input[1],
                    
                };
                studens.Add(someStudent);
                input = Console.ReadLine().Split();
            }

            var result = studens;
            foreach (var item in result)
            {
                Console.WriteLine(item.FirstName +" "+ item.LastName );
            }
        }
        public class Students
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
           
           
        }
    }
}
