using System;

namespace ConsoleApp8
{
    class ArvOgSånt
    {
        public static void Demo()
        {
            var b = new B();
            var d = new D();
            b.Abc();
            d.Abc();
            //var objekter = new C[] {new B(), new D()};
            //foreach (var o in objekter)
            //{
            //    o.Move();
            //}
        }
    }

    abstract class C
    {
        protected abstract void Move(); // MÅ overrides

        public virtual void Abc() // KAN overrides
        {
            Console.WriteLine("Abc");
        }

        public void Def()
        {
        }
    }

    class A // Superklasse  - base class
    {
        protected int n = 5;
        public void Something()
        {
            Console.WriteLine(n);
        }
    }

    class B : C  // Subklasse
    {
        protected override void Move()
        {
            Console.WriteLine("Move i B");
        }
    }

    class D : C  // Subklasse
    {
        protected override void Move()
        {
            Console.WriteLine("Move i D");
        }

        public override void Abc()
        {
            Console.Write("Før.");
            Console.WriteLine("Etter.");
        }
    }
}
