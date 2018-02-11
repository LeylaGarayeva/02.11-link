using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> students = new List<Person>();
            students.Add(new Person("Ismayil", "Ismayilov", 29));
            students.Add(new Person("Eli", "Allahverdiyev", 27));
            students.Add(new Person("Yaqub", "Allahverdiyev", 27));
            students.Add(new Person("Nicat", "Hemidov", 20));

            //List<Person> wanteds = new List<Person>();
            Person wanted = null;
            wanted = students.FirstOrDefault(f => f.age == 21);
            IEnumerable<Person> want = students.Where(f => f.age == 27);
        }
    }

    class Person {
        public string name { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public Person(string n,string l,int a)
        {


            name = n;
            lastname = l;
            age = a;
        }
    }

}
