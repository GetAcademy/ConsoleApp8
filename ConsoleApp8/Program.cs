using System;

namespace ConsoleApp8
{
    class Program
    {
        static uint Factorial(uint n)
        {
            if (n <= 1)
                return 1;
            else
            {
                var factorial = Factorial(n - 1);
                return n * factorial;
            }
        }

        static void Main(string[] args)
        {
            ArvOgSånt.Demo();
            //FileSearch.Search("git");
            return;
            

            for (uint i = 0; i < 20; i++)
                Console.WriteLine($"{i}!={Factorial(i):n0}");

            var a = new Person();
            var b = new Person();
            a.Name = "A";
            b.Name = "B";
            Person.Blurp = "Hallo";
            a.ObjectMethod();
            b.ObjectMethod();

            return;
            Person.Blurp = "Terje";
            var person = new Person();
            // ikke lov: person.Blurp = "fgb";
            person.Name = "Terje";
            // ikke lov: Person.Name = "kjh";

            Person.StaticMethod();
            // ikke lov: Person.ObjectMethod();
            person.ObjectMethod();
            // ikke lov: person.StaticMethod();
        }
    }

    class Person
    {
        public static string Blurp;
        public string Name;

        public static void StaticMethod()
        {
            Console.WriteLine(Blurp);
        }
        public void ObjectMethod()
        {
            Console.WriteLine(Name + Blurp);
        }
    }
}
