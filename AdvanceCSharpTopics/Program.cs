using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharpTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("overloading example");
            //Program pp = new Program();
            //pp.Add("yogesh", "tops");

            B classB = new B();
            classB.CaculateSalary();

            Console.ReadLine();
        }

        //same method name and different parameter ->overloading
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Add(string a, string b)
        {
            Console.WriteLine(a + "____" + b);
        }
    }

    class A
    {
        public void Test()
        {
            Console.WriteLine("class a - test method");
        }

        public virtual void CaculateSalary()
        {
            Console.WriteLine("virtual method");
        }
    }

    class B : A
    {
        public new void Test()
        {
            Console.WriteLine("class b - test method");
        }

        public override void CaculateSalary()
        {
            //base.CaculateSalary();
            Console.WriteLine("employee salary");
        }
    }
}
