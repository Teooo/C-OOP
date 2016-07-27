using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    public class OldestFamilyMember
    {
        public class Person
        {
            public string name;
            public int age;

            public Person(string name,int age)
            {
                this.name = name;
                this.age = age;
            }

        }
        public class Family
        {
            public List<Person> family;

            public Family()
            {
                this.family = new List<Person>();
            }
            public void AddMember(Person person)
            {
               this.family.Add(person);
            }

            public void GetOldestMember()
            {
                int maxAge = 0;
                var familyMembersAge = this.family.Select(f => f.age);
                foreach (var age in familyMembersAge)
                {
                    if (age >= maxAge)
                    {
                        maxAge = age;
                    }
                }
                var a = this.family.Where(f => f.age == maxAge).FirstOrDefault();
                Console.WriteLine($"{a.name} {a.age}");
            }
        }
        public static void Main()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split();

                Person p = new Person(personInfo[0],int.Parse(personInfo[1]));
             
                family.AddMember(p);                
            }
            family.GetOldestMember();
        }
    }
}
