using System;

namespace ptbac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c:");
            double c = double.Parse(Console.ReadLine());
            QuadraticEquation QuadraticEquation= new QuadraticEquation(a,b,c);
            Console.WriteLine(QuadraticEquation.Getter());
            Console.WriteLine("Giai phuong trinh:");
            double delta = QuadraticEquation.GetDiscriminant();
            if (delta > 0)
            {
                Console.WriteLine("x1= "+QuadraticEquation.GetRoot1(delta));
                Console.WriteLine("x2= "+QuadraticEquation.GetRoot2(delta));

            }    
            else if(delta==0)
            {
                Console.WriteLine("x1=x2= "+QuadraticEquation.GetRoot1(delta));
            }
            else
            {
                Console.WriteLine("The equation has no roots");
            }
            Console.ReadLine();
            Console.ReadKey();








        }
    }
}
