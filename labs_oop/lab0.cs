using System;
using System.Collections.Generic;

namespace lab1{
    class A
    {
        public void UseJ(J j)
        {
            Console.WriteLine("A использует J");
            j.PerformAction();
        }
    
        public void UseC(C c)
        {
            Console.WriteLine("A использует C");
            c.PerformAction();
        }
    }
    
    class J
    {
        public void UseK(K k)
        {
            Console.WriteLine("J использует K");
            k.PerformAction();
        }
    
        public void UseD(D d)
        {
            Console.WriteLine("J использует D");
            d.PerformAction();
        }
    
        public void PerformAction()
        {
            Console.WriteLine("J выполняет действие");
        }
    }
    
    class K
    {
        public void PerformAction()
        {
            Console.WriteLine("K выполняет действие");
        }
    }
    
    class D
    {
        public void PerformAction()
        {
            Console.WriteLine("D выполняет действие");
        }
    }
    
    class C
    {
        public void UseD(D d)
        {
            Console.WriteLine("C использует D");
            d.PerformAction();
        }
    
        public void UseE(E e)
        {
            Console.WriteLine("C использует E");
            e.PerformAction();
        }
    
        public void UseF(F f)
        {
            Console.WriteLine("C использует F");
            f.PerformAction();
        }
    
        public void PerformAction()
        {
            Console.WriteLine("C выполняет действие");
        }
    }
    
    class E
    {
        public void PerformAction()
        {
            Console.WriteLine("E выполняет действие");
        }
    }
    
    class F
    {
        public void PerformAction()
        {
            Console.WriteLine("F выполняет действие");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объекты классов
            A a = new A();
            J j = new J();
            K k = new K();
            D d = new D();
            C c = new C();
            E e = new E();
            F f = new F();
    
            // Демонстрация использования
            a.UseJ(j);
            a.UseC(c);
    
            j.UseK(k);
            j.UseD(d);
    
            c.UseD(d);
            c.UseE(e);
            c.UseF(f);
    
        }
    }
}
